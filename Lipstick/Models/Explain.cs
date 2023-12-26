namespace Lipstick.Models
{
    public class Explain
    {
        #region Require
        /* 
          
            Hello, Đây là series về asp.net core mvc (.Net 7)
           
            Series này được thực hiện theo phong cách: Kết hợp lý thuyết và thực hành.
            => Nhầm tránh việc các bạn viết code mà không hiểu đoạn code nó hoạt động như thế nào!
           
            Yêu cầu:
            + Đã học về lập OPP
            + Đã biết về ngôn ngữ lập trình.
            + Hiểu về cơ sở dữ liệu
          
         */
        #endregion
        #region Summary ASP.NET
        /*
        
            Trước khi thưởng thức món chính thì chúng ta sẽ dùng món khai vị trước nha !   
        
            Chúng ta sẽ tìm hiểu sơ bộ về asp.net là gì ?
            Nó có thể làm được gì?
            => Ref: https://dotnet.microsoft.com/en-us/apps/aspnet
        
            Như chúng ta đã biết, Một trang web động thì sẽ có:
            + Giao diện người dùng (font end).
            + Xử lý logic và tương tác với csdl ( back end).

            Vì vậy, đối với website lớn thì người ta sẽ chia ra làm 2 dự án:
            + Web UI 
            + Web API

            Thông thường sẽ có 2 sự lựa chọn về việc phát triển web UI, đó là:
            + Multiple page: Ví dụ điển hình là: Asp .Net core MVC ( có nhiều công nghệ khác).
            + Single page: Ví dụ điển hình là: Reactjs (có nhiều công nghệ khác).

            => Để biết thêm thông tin về sự khác nhau này thì search key word: 
            "Difference between single page and multiple page application"
        
            Trong ASP.Net sẽ hỗ trợ chúng ta công nghệ làm web UI như sau:
            + ASP.NET Core Blazor
            + ASP.NET Core Razor Pages
            + ASP.NET Core MVC
            + ASP.NET Core Single Page Applications (SPA) with frontend JavaScript frameworks
            => Ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/choose-web-ui?view=aspnetcore-7.0

         */
        #endregion
        #region Summary ASP.NET CORE MVC
        /*
        
            ASP.NET CORE MVC là web ui được render ở phía server và được phát triển dựa trên design pattern MVC.                  
            Ref: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio
         
         */

        #endregion
        #region Introduce Project
        /*
         
            Chúng ta sẽ làm về trang web thương mại điện tử bán son môi.
            Ref:https://lipstick.vn/
        
            Trong dự án này chúng ta sẽ chia làm 3 phần:
            + Web Client (ASP.Net Core MVC): Vai trò, trang web sẽ hiển thị thông tin sản phẩm và tương tác với khách hàng.
            + Web CRM (ASP.Net Core MVC): Vai trò, trang web sẽ tương tác với người quản lý trong việc thêm, xoá, sửa thông tin sản phẩm.
            + Web API (ASP.Net Core API): Vai trò, xử lý logic và tương tác với Web Client, Web CRM.
           
            Công nghệ thực hiện dự án:
            + Framework: Asp.net core API, Asp.net core MVC, Entity or Dapper.
            + Progamming languages: C#, Js.
            + Markup languages: Html
            + Style languages: Css ( chúng ta sẽ viết theo Sass 'Syntactically Awesome Stylesheet' rồi biên dịch thành css).
            + Labaries: Bootstrap, Jquery (Có luôn ajax nha các bạn!).

         */
        #endregion
        #region Setup Project
        /*
        
        Cài đặt Visual Studio 2022
        
        Cài đặt ASP.NET And web development

        Cài đặt exensions Compilor

         */
        #endregion
        #region AI Support
        /*
         * Ref: https://zzzcode.ai/answer-question
         */
        #endregion
    }
}
