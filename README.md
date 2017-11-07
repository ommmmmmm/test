# test

https://iace.org.tw/f2/rdFocus/showDetail?id=65&searchCondition.category=%E7%A0%94%E7%99%BC%E7%84%A6%E9%BB%9E

http://raveendraprakashsingh.blogspot.tw/2011/02/creating-powerpoint-slide-with-charts.html?m=1


https://code.msdn.microsoft.com/office/How-to-add-a-table-with-03578dde


https://github.com/tkrotoff/PptxTemplater?files=1



netoffice

https://msdn.microsoft.com/en-us/library/cc850834(office.14).aspx
https://www.codeproject.com/Tips/366463/Create-PowerPoint-presentation-using-PowerPoint-te
http://stackoverflow.com/questions/30190697/create-a-copy-of-template-presentation-potx-to-a-new-pptx-using-openxml


http://mantascode.com/c-get-text-content-from-microsoft-powerpoint-file/

http://csharphelper.com/blog/2013/08/create-a-powerpoint-presentation-that-makes-slides-corresponding-to-selected-styles-in-a-microsoft-word-document-in-c/

http://einboch.pixnet.net/blog/post/261074687-%E5%B0%87%E5%9C%96%E7%89%87%E6%8F%92%E5%85%A5%E5%88%B0microsoft-office-powerpoint-2007%E7%B0%A1%E5%A0%B1%E6%AA%94

using PPT = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

int idx = 0;
//使用Application類別，開啟PowerPoint應用程式
PPT.ApplicationClass app = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
//PowerPoint文件開啟可見
app.Visible = Office.MsoTriState.msoTrue;
//開啟簡報
PPT.Presentation prst = app.Presentations.Add(Office.MsoTriState.msoTrue);
 
//加入空白Slide
idx = prst.Slides.Count + 1;
prst.Slides.Add(idx, PPT.PpSlideLayout.ppLayoutBlank);
//加入圖片
prst.Slides[idx].Shapes.AddPicture(@"d:\tmp\picture.jpg", Office.MsoTriState.msoTrue, Office.MsoTriState.msoTrue, 0, 0, 720, 540);
 
//另存檔案
prst.SaveAs(@"d:\tmp\MyPpt.pptx", PPT.PpSaveAsFileType.ppSaveAsDefault, Office.MsoTriState.msoTrue);
//關閉檔案
prst.Close();
app.Quit();
//釋放資源
prst = null;
app = null;
GC.Collect();

https://www.codeproject.com/Questions/608096/WorkingpluswithpluslinepluschartsplusinplusPowerPo
https://support.microsoft.com/zh-tw/help/257757/considerations-for-server-side-automation-of-office
https://dotblogs.com.tw/shadow/2017/01/11/103354

font
http://forum.high-logic.com/viewtopic.php?t=941

megadownload
http://megadownloaderapp.blogspot.tw/

刪除投影片
https://msdn.microsoft.com/zh-tw/library/office/cc850840.aspx

highchart image server asp.net mail
Highcharts结合PhantomJS在服务端生成高质量的图表图片
http://www.cnblogs.com/jasondan/p/3504120.html


Highcharts in asp.net using jquery ajax
https://www.codeproject.com/articles/820349/highcharts-in-asp-net-using-jquery-ajax

highchart+table 结合phantomjs 一并生成图片
http://www.peng8.net/2014/11/24/highchart-table-export-image-by-phantomjs/

Highcharts结合PhantomJS在服务端生成高质量的图表图片
http://www.cnblogs.com/jasondan/p/3504120.html

利用 PhantomJS 搭建导出服务器 
https://bbs.hcharts.cn/thread-989-1-1.html

纯后台生成highcharts图片有哪些方法?
https://segmentfault.com/q/1010000004059640

highcharts-export-demo
https://github.com/zhaiyuyong/highcharts-export-demo

highchars图表组件实战篇：如何巧用phantomjs实现图表完美保存至服务器且中文无乱码
http://www.stepday.com/topic/?888

highCharts转PNG/JPG/PDF等格式,不用在线转换,本地高效率/java
http://www.yanweijia.cn/index.php/2016/08/03/highchartstopng/

My HighChart server
https://highchartsexport.wordpress.com/2016/04/30/first-blog-post/

[ASP.Net] 在IIS7中架設 Highcharts 的 Exporting 網站 
http://yilinliu.blogspot.tw/2012/03/aspnet-iis7-highcharts-exporting.html

highchart+table 结合phantomjs 一并生成图片 
http://www.peng8.net/tags/phantomjs/

BUG Export Script: OPTIONS variable missing
https://forum.highcharts.com/highcharts-usage/bug-export-script-options-variable-missing-t29818/


輕鬆快速安裝Microsoft SQL Server 2012資料庫
http://webcache.googleusercontent.com/search?q=cache:8reO7PWx2pIJ:download.ithome.com.tw/article/index/id/606+&cd=1&hl=zh-TW&ct=clnk&gl=tw



