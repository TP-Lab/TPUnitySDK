# iOS-Unity3D接入指南
注：本文为TP iOS SDK新手使用教程，只涉及教授SDK的使用方法，默认读者已经熟悉Unity 3D开发和Xcode开发工具的基本使用方法，以及具有一定的编程知识基础等。

### 下载仓库中的TPSDK-Unity.zip包

### 导入工程
1. 解压之后，双击TPSDK.unitypackage导入文件。
2. 选择目标GameObject(例如Main Camera)，在右侧栏中点击Add Component，选择TPSDK进行挂接。
3. 设置appID，未正确设置appID，可能导致App之间无法跳转。appID必须保证添加到Xcode工程的info.plist - URL Types.
5. 在info.plist中**LSApplicationQueriesSchemes**下添加一项，值为**tpoutside**
6. 在Project - Build settings 搜索Other Linker Flags, 加一项 **-ObjC**

## 压缩包内提供Unity Demo

1. 导入TPDemo.cs，选择目标GameObject挂接；
2. Mac上，cmd+shift+B弹出构建面板，选择iOS，再点击右下角的切换按钮，切换完成之后，点击build and run, 将会导出一个Xcode工程, 上述的info.plist即在此工程里面设置。
