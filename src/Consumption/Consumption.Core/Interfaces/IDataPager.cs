﻿/*
*
* 文件名    ：IDataPager                             
* 程序说明  : 程序基础页的数据分页接口
* 更新时间  : 2020-05-11
* 
* 
*
*/
namespace Consumption.Core.Interfaces
{
    /// <summary>
    /// 数据分页接口
    /// </summary>
    public interface IDataPager
    {
        /// <summary>
        /// 总行数
        /// </summary>
        int TotalCount { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        int PageIndex { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        int PageCount { get; set; }

        /// <summary>
        /// 首页
        /// </summary>
        void GoHomePage();

        /// <summary>
        /// 上一页
        /// </summary>
        void GoOnPage();

        /// <summary>
        /// 下一页
        /// </summary>
        void GoNextPage();

        /// <summary>
        /// 尾页
        /// </summary>
        void GoEndPage();

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageIndex"></param>
        void GetPageData(int pageIndex);
    }
}
