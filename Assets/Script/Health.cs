using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour, IHealth, IDamageable
{
    // Champs
    [SerializeField] int _startHealth;
    [SerializeField] int _maxHealth;
    [SerializeField] UnityEvent _onDeath;
    [SerializeField] EntityBlock _shield;

    [SerializeField] GameObject slider;
    // Propriétés
     public int CurrentHealth { get; private set; }
    public int MaxHealth => _maxHealth;
    public bool IsDead => CurrentHealth <= 0;

    // Events
    public event UnityAction OnSpawn;
    public event UnityAction<int> OnDamage;
    public event UnityAction OnDeath { add => _onDeath.AddListener(value); remove => _onDeath.RemoveListener(value); }

    public event UnityAction<float> OnSliderUpdate;

    // Methods
    void Awake() => Init();

    void Init()
    {
        
        _shield = transform.GetComponentInChildren<EntityBlock>();
        CurrentHealth = _startHealth;
        OnSpawn?.Invoke();
    }

    public void TakeDamage(int amount)
    {
        if (amount < 0) throw new ArgumentException($"Argument amount {nameof(amount)} is negativ");
        //Si le joueur bloque, aucun dégat n'est pris
        if (_shield is null || !_shield.GetIsBlocking())
        {
            var tmp = CurrentHealth;
            CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
            var delta = CurrentHealth - tmp;
            OnDamage?.Invoke(delta);


            if (CurrentHealth <= 0)
            {
                _onDeath?.Invoke();
            }
        }

    }

    [Button("test")]
    void MaFonction()
    {
        var enumerator = MesIntPrefere();

        while(enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }
    }


    List<IEnumerator> _coroutines;

    IEnumerator<int> MesIntPrefere()
    {

        //

        var age = 12;

        yield return 12;


        //

        yield return 3712;

        age++;
        //

        yield return 0;



        //
        yield break;
    }


    // La méthode ReloadGame est liée à l'event OnDeath dans l'inspector
    public void ReloadGame()
    {
        SceneManager.LoadScene("Game");
    }


    //Méthode permettant de soigner le joueur
    public void Heal()
    {
        CurrentHealth = MaxHealth;
    }

    public void SliderUpdate(float value)
    {
        slider.GetComponent<SliderManager>().UpdateSlider(value);
    }

}
