//去除网页中的连接地址
window.onload = inifA;
function inifA() {
    for (var i = 0; i < document.getElementsByTagName("a").length; i++) {
        document.getElementsByTagName("a")[i].onclick = function () { return false }
    }
}
//*定义必要的公共变量
var maker;//标注对象
var distance;//测距对象
var drawingManager;//绘图对象
var drag;//拖框缩放对象
//绘制工具栏外观设定
var styleOptions = {
    strokeColor: "red",    //边线颜色。
    fillColor: "red",      //填充颜色。当参数为空时，圆形将没有填充效果。
    strokeWeight: 3,       //边线的宽度，以像素为单位。
    strokeOpacity: 0.8,       //边线透明度，取值范围0 - 1。
    fillOpacity: 0.6,      //填充的透明度，取值范围0 - 1。
    strokeStyle: 'solid' //边线的样式，solid或dashed。
}
//*
//*结束//