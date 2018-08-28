# MSC 2018 Freshman Portal System

## 项目结构
#### 前端：React
```
./ClientApp
```
#### 后端：.NET Core 2.1
```
SDK 下载：https://www.microsoft.com/net/download
```

## Coding & Build
想用什么编辑器就用什么编辑器，以 vsc 举例，直接打开本项目文件夹即可。  
需要安装 C# 插件。  
#### Restore Packages
```
dotnet restore

cd ./ClientApp
npm install
```
#### Build
```
dotnet build -r 目标系统 -c 发布类型
```
目标系统为系统平台和架构的组合，例如 win-x64、linux-x64 等  
发布类型可为 Debug 或 Release，默认为 Debug

## Run & Debug
vsc 可以直接运行调试
#### Run
```
dotnet run
```

## Publish
```
dotnet publish -r 目标系统 -c 发布类型
```
发布完成后会生成到 ./bin/发布类型/netcoreapp2.1/publish 中  
复制里面的所有文件到目标机器上，运行 mscfreshman，网站将会自动启动并运行在 localhost:5000，可使用 nginx 等做反向代理将其映射至 80/443 端口