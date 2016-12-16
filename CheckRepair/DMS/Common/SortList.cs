/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 4:59:10 PM
 * */
using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace DMS.Common
{
    public class SortList : IBindingList
    {
        #region internal class SortListItem
        internal class SortListItem : IComparable
        {
            internal object m_Key;
            internal object m_Item;

            public SortListItem(object key, object item)
            {
                this.m_Item = item;
                this.m_Key = key;
            }

            #region IComparable Members

            public int CompareTo(object obj)
            {
                object target = ((SortListItem)obj).m_Key;

                if (m_Key is IComparable)
                {
                    return ((IComparable)m_Key).CompareTo(target);
                }
                else
                {
                    if (m_Key == null)
                    {
                        return 1;
                    }

                    if (m_Key.Equals(target))
                        return 0;
                    else
                        return m_Key.ToString().CompareTo(target.ToString());
                }
            }

            #endregion

            public override string ToString()
            {
                return m_Key.ToString();
            }

        }
        #endregion

        #region internal class SortEnumerator
        internal class SortEnumerator : IEnumerator
        {
            private ArrayList m_List;
            private ListSortDirection m_SortDirection;
            private int m_Index;

            public SortEnumerator(ArrayList list, ListSortDirection direction)
            {
                this.m_List = list;
                this.m_SortDirection = direction;
                Reset();
            }

            #region IEnumerator Members

            public void Reset()
            {
                if (m_SortDirection == ListSortDirection.Ascending)
                    m_Index = -1;
                else
                    m_Index = m_List.Count;
            }

            public object Current
            {
                get
                {
                    // TODO:  Add SortEnumerator.Current getter implementation
                    return ((SortListItem)m_List[m_Index]).m_Item;
                }
            }

            public bool MoveNext()
            {
                // TODO:  Add SortEnumerator.MoveNext implementation
                if (m_SortDirection == ListSortDirection.Ascending)
                {
                    if (m_Index < (m_List.Count - 1))
                    {
                        m_Index++;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (m_Index > 0)
                    {
                        m_Index--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            #endregion

        }

        #endregion

        #region SortList fields
        private IList m_List;
        private IBindingList m_BindingList;
        private bool m_SupportBinding;
        private bool m_Sorted = false;
        private ListSortDirection m_SortDirection = ListSortDirection.Ascending;
        private ArrayList m_SortedList = new ArrayList();
        private PropertyDescriptor m_SortBy;
        #endregion

        #region SortList constructors
        public SortList(IList list)
        {
            this.m_List = list;

            if (m_List is IBindingList)
            {
                m_BindingList = m_List as IBindingList;
                m_SupportBinding = true;
                m_BindingList.ListChanged += new ListChangedEventHandler(m_BindingList_ListChanged);
            }
        }
        #endregion

        #region SortList private members

        private void DoSort()
        {
            m_SortedList.Clear();

            if (m_SortBy == null)
            {
                foreach (object obj in m_List)
                    m_SortedList.Add(obj);
            }
            else
            {
                foreach (object obj in m_List)
                    m_SortedList.Add(new SortListItem(m_SortBy.GetValue(obj), obj));
            }

            m_SortedList.Sort();
            this.m_Sorted = true;

            ListChanged(this, new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        private void UndoSort()
        {
            m_SortedList.Clear();

            m_SortBy = null;
            m_SortDirection = ListSortDirection.Ascending;
            m_Sorted = false;

            ListChanged(this, new ListChangedEventArgs(ListChangedType.Reset, 0));
        }

        private object GetSortListItem(int index)
        {
            if (m_SortDirection == ListSortDirection.Ascending)
            {
                return ((SortListItem)m_SortedList[index]).m_Item;
            }
            else
            {
                return ((SortListItem)m_SortedList[m_SortedList.Count - 1 - index]).m_Item;
            }
        }
        #endregion

        #region IList Members

        public bool IsReadOnly
        {
            get
            {
                // TODO:  Add SortList.IsReadOnly getter implementation
                return true;
            }
        }

        public object this[int index]
        {
            get
            {
                if (m_Sorted)
                {
                    return GetSortListItem(index);
                }
                else
                {
                    return m_List[index];
                }
            }
            set
            {
                if (m_Sorted)
                {
                    int pos = m_SortedList.IndexOf(GetSortListItem(index));
                    m_List[pos] = value;
                    if (!m_SupportBinding)
                        DoSort();
                }
                else
                {
                    m_List[index] = value;
                }

            }
        }

        public void RemoveAt(int index)
        {
            if (m_Sorted)
            {
                m_List.RemoveAt(IndexOf(GetSortListItem(index)));
            }
            else
            {
                m_List.RemoveAt(index);
            }

        }

        public void Insert(int index, object value)
        {
            // TODO:  Add SortList.Insert implementation
            this.m_List.Insert(index, value);
        }

        public void Remove(object value)
        {
            this.m_List.Remove(value);
        }

        public bool Contains(object value)
        {
            return this.m_List.Contains(value);
        }

        public void Clear()
        {
            this.m_List.Clear();
        }

        public int IndexOf(object value)
        {
            if (m_Sorted)
            {
                int index = -1;
                foreach (SortListItem item in m_SortedList)
                {
                    if (item.m_Item.Equals(value))
                        return index;
                    index++;
                }
                return -1;
            }
            else
            {
                return m_List.IndexOf(value);
            }
        }

        public int Add(object value)
        {
            return this.m_List.Add(value);
        }

        public bool IsFixedSize
        {
            get
            {
                return m_List.IsFixedSize;
            }
        }

        #endregion

        #region ICollection Members

        public bool IsSynchronized
        {
            get
            {
                // TODO:  Add SortList.IsSynchronized getter implementation
                return m_List.IsSynchronized;
            }
        }

        public int Count
        {
            get
            {
                // TODO:  Add SortList.Count getter implementation
                return m_List.Count;
            }
        }

        public void CopyTo(Array array, int index)
        {
            m_List.CopyTo(array, index);
        }

        public object SyncRoot
        {
            get
            {
                return m_List.SyncRoot;
            }
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            if (!m_Sorted)
                return m_List.GetEnumerator();
            else
            {
                return new SortEnumerator(m_SortedList, m_SortDirection);
            }
        }

        #endregion

        #region IBindingList Members

        public void AddIndex(PropertyDescriptor property)
        {
            if (m_SupportBinding)
                m_BindingList.AddIndex(property);
        }

        public bool AllowNew
        {
            get
            {
                if (m_SupportBinding)
                    return m_BindingList.AllowNew;
                else
                    return false;
            }
        }

        public void ApplySort(PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
        {
            this.m_SortDirection = direction;
            this.m_SortBy = property;

            DoSort();
        }

        public PropertyDescriptor SortProperty
        {
            get
            {
                return m_SortBy;
            }
        }

        public int Find(PropertyDescriptor property, object key)
        {
            if (m_SupportBinding)
                return m_BindingList.Find(property, key);
            return 0;
        }

        public bool SupportsSorting
        {
            get
            {
                return true;
            }
        }

        public bool IsSorted
        {
            get
            {
                return m_Sorted;
            }
        }

        public bool AllowRemove
        {
            get
            {
                if (m_SupportBinding)
                    return m_BindingList.AllowRemove;
                else
                    return false;
            }
        }

        public bool SupportsSearching
        {
            get
            {
                if (m_SupportBinding)
                    return m_BindingList.SupportsSearching;
                else
                    return false;
            }
        }

        public System.ComponentModel.ListSortDirection SortDirection
        {
            get
            {
                return m_SortDirection;
            }
        }

        public event System.ComponentModel.ListChangedEventHandler ListChanged;

        public bool SupportsChangeNotification
        {
            get
            {
                return true;
            }
        }

        public void RemoveSort()
        {
            this.UndoSort();
        }

        public object AddNew()
        {
            if (m_SupportBinding)
                return m_BindingList.AddNew();
            return null;
        }

        public bool AllowEdit
        {
            get
            {
                if (m_SupportBinding)
                    return m_BindingList.AllowEdit;
                else
                    return false;
            }
        }

        public void RemoveIndex(PropertyDescriptor property)
        {
            if (m_SupportBinding)
                m_BindingList.RemoveIndex(property);
        }

        #endregion

        #region EventHandlers
        private void m_BindingList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (m_Sorted)
            {
                if (e.ListChangedType == ListChangedType.ItemAdded)
                {
                    SortListItem item = new SortListItem(m_SortBy.GetValue(m_List[e.NewIndex]),
                        m_List[e.NewIndex]);
                    if (m_SortDirection == ListSortDirection.Ascending)
                    {
                        m_SortedList.Add(item);
                    }
                    else
                    {
                        m_SortedList.Insert(0, item);
                    }
                }
                else
                {
                    this.DoSort();
                }
            }
            else
            {
                ListChanged(this, e);
            }
        }
        #endregion
    }
}
