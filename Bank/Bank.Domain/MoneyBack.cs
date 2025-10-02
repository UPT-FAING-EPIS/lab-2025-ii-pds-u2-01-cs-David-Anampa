namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta MoneyBack.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
    /// <summary>
    /// Devuelve el tipo de tarjeta MoneyBack.
    /// </summary>
    /// <returns>"MoneyBack"</returns>
    public string GetCardType()
        {
            return "MoneyBack";
        }
    /// <summary>
    /// Devuelve el límite de crédito para MoneyBack.
    /// </summary>
    /// <returns>Límite de crédito.</returns>
    public int GetCreditLimit()
        {
            return 15000;
        }
    /// <summary>
    /// Devuelve el cargo anual para MoneyBack.
    /// </summary>
    /// <returns>Cargo anual.</returns>
    public int GetAnnualCharge()
        {
            return 500;
        }
    }
}