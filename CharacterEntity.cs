using UnityEngine;

public abstract class CharacterEntity
{
    public CharacterEntityData dataHp;

    public CharacterEntity(CharacterEntityData data)
    {
        dataHp = data;
    }

    protected abstract void OnDead();

    /**
     * Remove hp by amount and if hp <= 0 then run onDead()
     */
    public void RemoveHp(int amount)
    {
        dataHp.hp -= amount;

        if (dataHp.hp <= 0)
        {
            OnDead();
        }
    }

    /**
     * Add hp by amount and if hp >= maxHp then hp = mxHp
     */
    public void AddHp(int amount)
    {
        if (dataHp.hp + amount >= dataHp.maxHp)
        {
            dataHp.hp = dataHp.maxHp;
            return;
        }
        dataHp.hp += amount;
    }
}
