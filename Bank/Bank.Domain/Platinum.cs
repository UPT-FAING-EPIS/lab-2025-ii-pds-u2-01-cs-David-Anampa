namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta Platinum.
    /// </summary>
    public class Platinum : ICreditCard
    {
    /// <summary>
    /// Devuelve el tipo de tarjeta Platinum.
    /// </summary>
    /// <returns>"Platinum Plus"</returns>
    public string GetCardType()
        {
            return "Platinum Plus";
        }
    /// <summary>
    /// Devuelve el límite de crédito para Platinum.
    /// </summary>
    /// <returns>Límite de crédito.</returns>
    public int GetCreditLimit()
        {
            return 35000;
        }
    /// <summary>
    /// Devuelve el cargo anual para Platinum.
    /// </summary>
    /// <returns>Cargo anual.</returns>
    public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}