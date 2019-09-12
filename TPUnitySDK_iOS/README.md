# iOS-Unity3D接入指南
注：本文为TP iOS SDK新手使用教程，只涉及教授SDK的使用方法，默认读者已经熟悉Unity 3D开发和Xcode开发工具的基本使用方法，以及具有一定的编程知识基础等。

### 下载仓库中的TPSDK-Unity.zip包

### 导入工程
1. 解压之后，双击TPSDK.unitypackage导入文件。
2. 选择目标GameObject(例如Main Camera)，在右侧栏中点击Add Component，选择TPSDK进行挂接。
3. 设置appID，未正确设置appID，可能导致App之间无法跳转。appID必须保证添加到Xcode工程的`info.plist` -> **URL Types**.
5. 在`info.plist`中**LSApplicationQueriesSchemes**下添加一项，值为**tpoutside**
6. 在**Project** -> **Build settings** 搜索**Other Linker Flags**, 加一项 **-ObjC**

## 压缩包内提供Unity Demo

1. 导入TPDemo.cs，选择目标GameObject挂接；
2. Mac上，cmd+shift+B弹出构建面板，选择iOS，再点击右下角的切换按钮，切换完成之后，点击build and run, 将会导出一个Xcode工程, 上述的info.plist即在此工程里面设置。


# iOS-Unity3D Guidance
Note: This article is a tutorial for the TP iOS SDK novice, only involves the usage of the SDK. By default, reader is already familiar with the basic use of Unity 3D development and Xcode development tools, as well as a certain programming knowledge base.

### Download the TPSDK-Unity.zip package in this repository

### Importing Project
1. After unzipping, double-click on the TPSDK.unitypackage to import sdk files.
2. Select the target GameObject (for example, Main Camera), click Add Component in the right column, and select TPSDK to mount.
3. Set the appID. If the appID is not set correctly, the app may not be able to jump. appID must be guaranteed to be added to the Xcode project's `info.plist` -> **URL Types**.
5. Add an item in the info.plist **LSApplicationQueriesSchemes** with a value of **tpoutside**
6. Search for **Other Linker Flags** in **Project** -> **Build settings**, add an item **-ObjC**

## Zip file contains the Unity Demo 

1. Import TPDemo.cs and select the target GameObject hook;
2. On the Mac, cmd+shift+B pops up the build panel, select iOS, and then click the toggle button in the lower right corner. After the switch is complete, click build and run, and an Xcode project will be exported. The above info.plist is in this project. Set inside.
