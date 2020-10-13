# ReadJson-WelcomeAnimation

This small project include a simple text animation effect for C#, by using windows form structure, which will change font's color from black to white, so that we can have a welcome interface as other UI.
And an example to read JSON file by using Newtonsoft.


## Question 1 : Why the file reader shows null in the file content?
We need to set the properties of the file as it always clone to the output directory, and generate its content.

## Question 2 : Why do we use dynamic method?
```c#
string content = sb.ToString();
var jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
```
We can use what we want, dynamic is just a dirty work.

---------------

这是一个小项目，包含了一个Json文件的读取和文字动态效果的小实验，项目语言是c#，用的是winform架构。读取Json用的是Newtonsoft包。

##问题1：为什么我文件路径正确但是读取出来没有内容？
对于想要读取的文本文件，需要先将它作为现有项加入解决方案资源管理器，并且设置其属性为始终复制到输出目录，生成操作为内容。我试过将读取路径设置为bin的父目录，以读取原始文件，但是仍然读取不出来。所以复制内容到bin仍然是有必要的。


##问题2：为什么读取Json内容的方法是Dynamic？

```c#
string content = sb.ToString();
var jsonObject = JsonConvert.DeserializeObject<dynamic>(content);
```
当然可以用别的，我只是懒得写结构了。官网写的蛮清楚了，这篇只是踩坑。
