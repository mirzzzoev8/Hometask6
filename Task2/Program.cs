class Student{
    string fullname;
    int age;
    int grade;
    public Student(){}
    public Student(string name, int age){
        fullname = name;
        this.age = age;
    }
    public Student(string name,  int age, int grade){
          fullname = name;
          this.age = age;
          this.grade = grade;
    }
    public string Study(){
         return $"{fullname} is teaching ";
    }
    public void SetGrade(int newGrade){
        grade = newGrade;
    }
    public int GetGrade(){
       return grade;
    }
}