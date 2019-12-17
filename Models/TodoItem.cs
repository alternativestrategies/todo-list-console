namespace console_mysql.Models
{
    public class TodoItem
    {
        public int Id {get; set;}
        public string Task {get; set;}
        public int Status {get; set;}
        public int UserId {get; set;}
    }
}