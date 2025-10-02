namespace Bank.Domain
{
    /// <summary>
    /// Interfaz para tarjetas de crédito.
    /// </summary>
    public interface ICreditCard
    {
    /// <summary>
    /// Devuelve el tipo de tarjeta de crédito.
    /// </summary>
    /// <returns>Tipo de tarjeta.</returns>
    string GetCardType();
    /// <summary>
    /// Devuelve el límite de crédito de la tarjeta.
    /// </summary>
    /// <returns>Límite de crédito.</returns>
    int GetCreditLimit();
    /// <summary>
    /// Devuelve el cargo anual de la tarjeta.
    /// </summary>
    /// <returns>Cargo anual.</returns>
    int GetAnnualCharge();
    }
}