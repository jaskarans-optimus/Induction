using System;
namespace Assignment10
{
    class univPeople
    {
        Students[] students = new Student[3];
        WorkingStaff[] staffMembers;
        public univPeople()
        {
            Student Ankit = new Student();
            Ankit.fullName = "Ankit Mathur";
            Ankit._age = 25;
            //  As '_age'  field is declared internal and protected ,we cannot set the value of '_age' because we need inherit Student class 

            students[0] = Ankit;
        }
    }
}
