namespace helloword
{
    internal class Program
        /* cú pháp tạo class
         * internal: chỉ định truy cập: khai báo mức độ truy cập
         * class: từ khóa
         * program: tên class */

    {
        static void Main(string[] args)
            /*đây là phương thức ( 
            Main: tên phương thức, tham số của main trả về một mảng string (kiểu dữ liệu string) arg nghĩa là tên của biến 
            void: đánh dấu phương thức không trả về gì
            static: một hàm tĩnh cho phép gọi trực tiếp*/
        {
            Console.WriteLine("Hello, World!");
        }
    }
    /* class và phương thức nói trên đều phải được khai báo trong namespace
     * Chia thành nhiều namespace để quản lý như nhiều phòng
     * Mỗi phòng có các đồ vật là class
     * Chức năng của đồ vật là phương thức */
    // mỗi câu lệnh đều phải kết thúc bằng dấu ;

    /* 
       Using system
    //khai báo một cách tường minh, ở trong bài không cần khai báo tường minh bởi vì đã có lệnh ImplicitUsings cho phép sử dụng thư viện một cách ngầm định
    // là một namespace của hệ thống chứa rất nhiều thư viện trong đó có một class là System.Console 
       namespace helloword
{
    {
        static void Main(string[] args)  
            {
                Console.WriteLine("Hello, World!"); //Console với nhiệm vụ cung cấp chuẩn nhập xuất dữ liệu Input, Output. Nó không thể được kế thừa vì đây là một class của hệ thống
    // dòng dữ liệu Hello, World! là một hằng số, một chuỗi cố định nên được bao bọc trong dáu nháy kép       
    }
    }
}

*/
}