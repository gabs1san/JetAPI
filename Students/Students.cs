namespace DotNg.Students;

public class Students
{
    public Guid Id { get; init; }
    public string Nome { get; private set; }
    public bool Active { get; private set; }

    public Students(string nome)
    {
        Nome = nome;
        Id = Guid.NewGuid();
        Active = true;
    }

    public void UpdateName(string nome)
    {
        Nome = nome;
    }

    public void Desactive()
    {
        Active = false;
    }
}