using UnityEngine;

public class Player : Inhabitant
{

    private Room currentRoom;
    protected int HP = Random.Range(0, 32) + 1;

    public Player(string name) : base(name)
    {
        this.currentRoom = null;
    }

    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }
    
    public void setCurrentRoom(Room r)
    {
        this.currentRoom = r;
    }
       public String getName()
    {
        return this.name;
    }
    public void getHP()
    {
        return this.HP;
    }
}
