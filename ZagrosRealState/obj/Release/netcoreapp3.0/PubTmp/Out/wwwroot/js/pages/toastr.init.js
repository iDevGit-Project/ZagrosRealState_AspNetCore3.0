!function(p){"use strict";var t=function(){};t.prototype.send=function(t,i,o,e,n,a,s,r){a||(a=3e3),s||(s=1);var c={heading:t,text:i,position:o,loaderBg:e,icon:n,hideAfter:a,stack:s};r&&(c.showHideTransition=r),console.log(c),p.toast().reset("all"),p.toast(c)},p.NotificationApp=new t,p.NotificationApp.Constructor=t}(window.jQuery),function(i){"use strict";i("#toastr-one").on("click",function(t){i.NotificationApp.send("سر به بالا!","این هشدار به توجه شما نیاز دارد، اما فوق العاده مهم نیست.","top-right","#3b98b5","info")}),i("#toastr-two").on("click",function(t){i.NotificationApp.send("Heads up!","Check below fields please.","top-center","#da8609","warning")}),i("#toastr-three").on("click",function(t){i.NotificationApp.send("آفرین!","شما با موفقیت این پیام هشدار مهم را خوانده اید","top-right","#5ba035","success")}),i("#toastr-four").on("click",function(t){i.NotificationApp.send("مشکلی هست!","چند چیز را تغییر دهید و دوباره امتحان کنید.","top-right","#bf441d","error")}),i("#toastr-five").on("click",function(t){i.NotificationApp.send("چگونه به کمک نیاز دارید؟",["انبار مخزن بفرست","Improve/extend the functionality","یک درخواست کشیدن ایجاد کنید"],"top-right","#1ea69a","info")}),i("#toastr-six").on("click",function(t){i.NotificationApp.send("Can I add <em>icons</em>?","Yes! check this <a href='https://github.com/kamranahmedse/jquery-toast-plugin/commits/master'>update</a>.","top-right","#1ea69a","info",!1)}),i("#toastr-seven").on("click",function(t){i.NotificationApp.send("","Set the `hideAfter` property to false and the toast will become sticky.","top-right","#1ea69a","")}),i("#toastr-eight").on("click",function(t){i.NotificationApp.send("","Set the `showHideTransition` property to fade|plain|slide to achieve different transitions.","top-right","#1ea69a","info",3e3,1,"fade")}),i("#toastr-nine").on("click",function(t){i.NotificationApp.send("Slide transition","Set the `showHideTransition` property to fade|plain|slide to achieve different transitions.","top-right","#1ea69a","info",3e3,1,"slide")}),i("#toastr-ten").on("click",function(t){i.NotificationApp.send("گذار ساده","ویژگی 'showHideTransition' را برای محو شدن ساده، اسلاید برای رسیدن به انتقالهای مختلف تنظیم کنید.","top-right","#3b98b5","info",3e3,1,"plain")})}(window.jQuery);