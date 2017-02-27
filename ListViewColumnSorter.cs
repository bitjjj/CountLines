using System.Collections;
using System.Windows.Forms;

namespace CountLines
{
    /// <summary>
    /// 点击列表表头时排序列表项
    /// </summary>
    class ListViewColumnSorter:IComparer
    {
        private int ColumnToSort;

        //private

        public int SortColumn
        {
            get { return ColumnToSort; }
            set { ColumnToSort = value; }
        }

        private SortOrder OrderOfSort;

        public SortOrder Order
        {
            get { return OrderOfSort; }
            set { OrderOfSort = value; }
        }
        private CaseInsensitiveComparer ObjectCompare;
        
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare=new CaseInsensitiveComparer();
        }
        
        int IComparer.Compare(object x,object y)
        {
            int compareResult;
            ListViewItem listviewX = (ListViewItem)x;
            ListViewItem listviewY = (ListViewItem) y;

            int col1 = 0, col2 = 0;
            if (int.TryParse(listviewX.SubItems[ColumnToSort].Text, out col1) && int.TryParse(listviewY.SubItems[ColumnToSort].Text, out col2))
            {
                compareResult = col1 >= col2 ? (col1 == col2 ? 0 : 1) : -1;
            }
            else
            {
                compareResult =
                    ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            }
            if(OrderOfSort==SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                return -compareResult;
            }
            else
            {
                return 0;
            }
        }
    }
}
