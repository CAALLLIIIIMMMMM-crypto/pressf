using System;
using System.Text;
using TMPro;
using UnityEngine;

public class ZadachnikPoCofe : MonoBehaviour
{
    public TMP_Text text;

    private ZakazInfo ZakazInfo;

    private void Start()
    {
        ZakazSystem.Instance.onZakazStart += OnStartZakaz;
        
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        if (ZakazSystem.Instance != null)
            ZakazSystem.Instance.onZakazStart -= OnStartZakaz;
    }

    public void OnStartZakaz(ZakazInfo zakazInfo)
    {
        gameObject.SetActive(true);
        
        ZakazInfo = zakazInfo;

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Приготовьте эспрессо:");
        sb.AppendLine("1. Подготовьте портафильтр.");
        sb.AppendLine("2. Засыпьте молотый кофе.");
        sb.AppendLine("3. Равномерно распределите кофе.");
        sb.AppendLine("4. Утрамбуйте кофе темпером.");
        sb.AppendLine("5. Установите портафильтр в кофемашину.");
        sb.AppendLine("6. Запустите приготовление.");
        sb.AppendLine("7. Дождитесь завершения экстракции.");
        sb.AppendLine("8. Заберите готовый эспрессо.");

        text.text = sb.ToString();
    }
}