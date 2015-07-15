
namespace Assignment10
{
    class univPeople:Student
    {
        Students[] students = new Student[3];
        WorkingStaff[] staffMembers;
        public univPeople(){
            Student Ankit = new Student();
            Ankit.fullName="Ankit Mathur";
            Ankit._age = 25;
            //As '_age'  field is declared internal ,we cannot set the value of '_age' because we need to be in the same assembly as Student to access _age
           
            students[0]=Ankit;
    }
}
