public abstract class Animal {

    protected int age;
    public event Action<string, int>? age_changed;

    public Animal (int initial_age){
        age = initial_age;
    }

    protected void on_age_changed(){
        age_changed?.Invoke(this.GetType().Name, age);
    }
}