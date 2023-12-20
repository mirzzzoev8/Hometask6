class Teacher {
     string fullName;
     string subject;
     int experience;


     public Teacher(){}
    public Teacher(string name, string sub){
        fullName = name;
        subject = sub ;
    }
    public Teacher(string name, string sub, int experience){
        fullName = name;
        subject = sub ;
        this.experience = experience;
    }

    
    public string Teach(){
        return $"{fullName} is teaching {subject}";
    }
    public void SetExperience(int years){
        experience = years;
    }
    public int GetExperience(){
        return experience;
    }
    
    
}