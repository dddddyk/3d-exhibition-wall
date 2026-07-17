// 第1行：using 相当于C/C++的#include，引入Unity的命名空间
using UnityEngine;

// 第2行：public class 类名 : MonoBehaviour
// - public：公开的，别的脚本也能访问
// - class：声明这是一个类（图纸）
// - HelloWorld：类名，必须和文件名一模一样！
// - : MonoBehaviour：继承MonoBehaviour，告诉Unity"这是个能挂在物体上的脚本"
public class HelloWorld : MonoBehaviour
{
    // 第3行：这是一个"成员变量"，写在类里面、函数外面
    // public的变量会显示在Unity的Inspector面板里，可以直接在界面改
    // string是字符串类型，相当于C++的std::string
    public string myName = "文物墙";
    
    // 第4行：Start()函数
    // 这是Unity的"生命周期函数"——游戏开始时自动调用一次
    // 相当于C++的构造函数，但不是new的时候调用，是游戏运行第一帧调用
    void Start()
    {
        // 第5行：Debug.Log() 相当于C语言的printf，在Unity控制台输出文字
        // 字符串拼接用+号，和C++一样
        Debug.Log("游戏开始了！我是：" + myName);
    }

    // 第6行：Update()函数
    // 这也是Unity的"生命周期函数"——每一帧都会调用一次
    // 游戏大概每秒跑60帧，所以这个函数每秒会执行60次
    // 所有需要实时更新的代码（比如移动、旋转）都写在这里
    void Update()
    {
        // 第7行：检测键盘按键——如果按下了空格键
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("你按了空格键！");
        }
    }
}
