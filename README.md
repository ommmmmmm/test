# test


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
