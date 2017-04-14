using System;
using System.Collections.Generic;
using System.Text;

namespace ChefMonitor
{
    public class CSortStyle
    {
        static public string GetSort(int iSortStyle)
        {
            /*
             送厨时间
             * 菜名
             * 类型
             * 下单时间
             * 部门,送厨时间
             * 部门,下单时间
             * 台名,送厨时间
             * 台名,下单时间
             * 部门,台名,送厨时间
             * 部门,台名,下单时间
             * 部门,台名,出厨时间
             */
            switch (iSortStyle)
            {
                case 0:
                    return "OrderTime";//送厨时间
                    break;
                case 1:
                    return "GoodsName";//菜名
                    break;
                case 2:
                    return "Type";//类型
                case 3:
                    return "RecordTime";//下单时间
                case 4:
                    return "DeptName,OrderTime";//部门,送厨时间
                case 5:
                    return "DeptName,RecordTime";//部门,下单时间
                case 6:
                    return "TableName,OrderTime"; //台名,送厨时间   
                case 7:
                    return "TableName,RecordTime"; //台名,下单时间 
                case 8:
                    return "DeptName,TableName,OrderTime";//部门,台名,送厨时间   
                case 9:
                    return "DeptName,TableName,RecordTime";//部门,台名,下单时间 
                case 10:
                    return "DeptName,TableName,ServingTime";//部门,台名,出厨时间
                default:
                    return "OrderTime";
            }
        }
    }
}
