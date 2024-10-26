using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GameObject player1 = new GameObject("Player1", 100);
        GameObject player2 = new GameObject("Player2", 100);
        GameObject player3 = new GameObject("Player3", 100);

        Game game = new Game();

        // Подписываем объекты на события
        game.AttackEvent += player1.OnAttack;
        game.AttackEvent += player2.OnAttack;
        game.HealEvent += player3.OnHeal;

        // Запускаем события
        Console.WriteLine("Первый раунд:");
        game.Attack(20);
        game.Heal(15);

        Console.WriteLine("\nВторой раунд:");
        game.Attack(30);
        game.Heal(10);

        // Проверяем состояния объектов
        Console.WriteLine("\nСостояние объектов:");
        player1.DisplayStatus();
        player2.DisplayStatus();
        player3.DisplayStatus();
    }
}

class Game
{
    public event Action<int> AttackEvent;
    public Action<int> HealEvent;

    public void Attack(int damage)
    {
        Console.WriteLine($"Атака на {damage} урона!");
        AttackEvent?.Invoke(damage);
    }

    public void Heal(int healAmount)
    {
        Console.WriteLine($"Лечение на {healAmount} здоровья!");
        HealEvent?.Invoke(healAmount);
    }
}

class GameObject
{
    public string Name { get; }
    public int Health { get; private set; }

    public GameObject(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void OnAttack(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} получил {damage} урона. Текущее здоровье: {Health}");
    }

    public void OnHeal(int healAmount)
    {
        Health += healAmount;
        Console.WriteLine($"{Name} восстановил {healAmount} здоровья. Текущее здоровье: {Health}");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"{Name}: {Health} здоровья");
    }
}