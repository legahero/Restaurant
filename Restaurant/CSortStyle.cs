using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class CSortStyle
    {
        static public string GetSort(int iSortStyle)
        {
            /*
             台号
             * 台名
             * 部门
             * 台类
             * 台ID
             
             */
            switch (iSortStyle)
            {
                case 0:
                    return "TableNO";//台号
                case 1:
                    return "TableName";//台名
                case 2:
                    return "DeptName";//部门
                case 3:
                    return "TableClassifyID";//台类
                case 4:
                    return "DiningTableID";//台ID
                default:
                    return "DiningTableID";
            }
        }
    }
}
