namespace Bank.Domain
{
    /// <summary>
    /// Fábrica simple para obtener instancias de tarjetas de crédito según el tipo.
    /// </summary>
    public class CreditCardFactory
    {
    /// <summary>
    /// Devuelve una instancia de ICreditCard según el tipo especificado.
    /// </summary>
    /// <param name="cardType">Tipo de tarjeta: MoneyBack, Titanium, Platinum.</param>
    /// <returns>Instancia de ICreditCard correspondiente.</returns>
    public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails; 
        }
    }
}