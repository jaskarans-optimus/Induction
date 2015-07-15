//Problem 1: Mention if the code below will run successfully or not.
namespace Assignment10
{
    class Student
    {
        protected int _age;
        protected internal int _rollNo;
    }
    class CollegeStudent
    {
        public static void Main()
        {
            CollegeStudent stu = new CollegeStudent();
            stu._age = 10;
            //Code will fail
            //CollegeStudent class object do not have access to the '_age' field of the 'Student' class
            //as '_age' field's access specifier so only the class that inherits 'Student' class will have access this field
        }
    }

}
