C# 学习笔记

----------------------------------------
调用库
using + 库名
否则需要加前缀 库名.函数名
----------------------------------------
类
class 命名类
应用样例：
<access specifier> class  class_name 
{
    // member variables
    <access specifier> <data type> variable1;
    <access specifier> <data type> variable2;
    ...
    <access specifier> <data type> variableN;
    // member methods
    <access specifier> <return type> method1(parameter_list) 
    {
        // method body 
    }
    <access specifier> <return type> method2(parameter_list) 
    {
        // method body 
    }
    ...
    <access specifier> <return type> methodN(parameter_list) 
    {
        // method body 
    }
}

access specifier : 访问标识符，对类默认为internal,成员默认为private;
----------------------------------------
变量类型及声明

变量命名规则：
不可含符号和数字
多单词组合的变量用Camel规则： 首字母小写，其余各单词首字母大写
如:whaleSong, theRealDrummer

字符串string
string variable1, variable2
string variable1 = <content>
字符串可用+号连接
占位符format方法：
"str0{0}{1}", str1, str2 = str0 + str1 + str2

整型8种
通常用int和long 出于节约空间等考虑可使用另外六种

小数
float 大小32bit 范围从 ±1.5*10^-45 ~ ±3.4*10^38 7位有效数字
double 大小64bit 范围从 ±5.0*10^-324 ~ ±1.7*10^308 15~16位有效数字
decimal 大小128bit 范围从 ±1.0*10^-28 ~ ±7.9*10^28 28~29位有效数字（通常用于金融计算）
----------------------------------------
数据输入/输出

数据输入
控制台输入
System.Console.ReadLine() 读取一行数据,读取后换行      变量类型string
System.Console.Read() 读取一行字符串的ascii值        变量类型int
System.Console.ReadKey() 读取用户的单个按键      变量类型ConsolKeyInfo

打印数据
命令行内输出
System.Console.WriteLine() 输出为单独一行
System.Console.Write() 输出与后一行连接

Console : 控制台
----------------------------------------