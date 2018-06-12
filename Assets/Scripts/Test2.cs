using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private string name;

    public Boss(string name, int hp, int power, int mp)
    {
        this.hp = hp;
        this.power = power;
        this.mp = mp;
        this.name = name;
    }

    public void Attack()
    {
        Debug.Log(this.name + "は" + this.power + "のダメージを与えた！");
    }

    public void Magic()
    {
        this.mp -= 5;
        Debug.Log(
            (this.mp > 0) ?
                this.name + "は魔法攻撃をした。残りMPは" + this.mp +'。'
                :
                this.name + "はMPが足りないため魔法が使えない。"
            );
    }

    public void Defence(int damage)
    {
        Debug.Log(this.name + "は" + damage + "のダメージを受けた！");
        this.hp -= damage;
    }

}

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss boss = new Boss("ピカチュウ", 50000, 99999, 53);
        boss.Magic();
        Enumerable.Range(0, 10).ToList().ForEach(_ => boss.Magic());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
