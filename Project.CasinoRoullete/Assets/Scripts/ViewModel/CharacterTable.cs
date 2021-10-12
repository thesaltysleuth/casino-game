using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Components;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Character Table", menuName = "Scriptable/Character Table")]
    public class CharacterTable : ScriptableObject
    {
        public string tableName;
        public GameObject chipPrefab;
        public CharacterMoney characterMoney;

        public int currentTableCounter;
        public Chip currentChipSelected;
        public List<ChipGame> currentTable = new List<ChipGame>();

        public ISubject<bool> OnActiveButton = new Subject<bool>();
        public ISubject<bool> OnRound = new Subject<bool>();
    }
}