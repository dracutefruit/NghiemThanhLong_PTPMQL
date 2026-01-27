CẤU TRÚC PROJECT .NET MVC

- Tên project (MVCMOVIE / MVCApp / …):
  Thư mục gốc của ứng dụng, chứa toàn bộ source code và cấu hình dự án.

- Controllers:
  Chứa các controller, xử lý request từ View, thực hiện logic và trả kết quả về View.

- Models:
  Chứa các lớp đại diện cho dữ liệu/CSDL của ứng dụng.

- Views:
  Chứa các file giao diện (.cshtml), hiển thị dữ liệu cho người dùng.

- wwwroot:
  Chứa các file tĩnh của dự án như HTML, CSS, JavaScript, hình ảnh.

- appsettings.json, appsettings.Development.json:
  Chứa cấu hình ứng dụng (chuỗi kết nối CSDL, cấu hình môi trường).

- Program.cs:
  File cấu hình và khởi động ứng dụng ASP.NET MVC.

- bin/, obj/:
  Thư mục sinh ra trong quá trình build, không chỉnh sửa thủ công.

ĐỊNH TUYẾN (ROUTING) TRONG ASP.NET MVC

- MVC sẽ gọi bộ điều khiển (Controller) và các hành động bên trong (Action) thông qua URL

- Logic định tuyến MVC sử dụng dạng: /[Controller]/[Action]/[Parameters]

- Định tuyến được cấu hình trong file Program.cs:

CONTROLLER TRONG MVC

- Tên của Controller bắt buộc phải có phần hậu tố Controller: Ví dụ StudentController, PersonController

- Nằm trong thư mục Controllers

- Nhiệm vụ của Controller:

	* Xử lý các yêu cầu của người dùng gửi tới từ View.

	* Truy xuất dữ liệu trong cơ sở dữ liệu.

	* Gọi các mẫu View và trả về dữ liệu

VIEW TRONG MVC

- Có phần mở rộng là “.cshtml”

- Nằm trong thư mục Views/Controler_Name (tương ứng với HelloWorldController sẽ có thư mục HelloWorld trong thư mục Views)

- Nhiệm vụ của View: Cung cấp giao diện người dùng (HTML) bằng C#
