﻿/*
*
* 文件名    ：IModuleComponent                             
* 程序说明  : 程序基础模块接口
* 更新时间  : 2020-05-11
* 更新人    : zhouhaogg789@outlook.com
* 
*
*/
namespace Consumption.Core.Interfaces
{

    public interface IModuleComponent
    {
        void Resgiter();

        void GetMoudles();

        bool Verify(string m);
    }
}
