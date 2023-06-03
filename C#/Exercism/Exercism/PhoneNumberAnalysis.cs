using System;

//Este exercício permite que você analise números de telefone.

//Você é solicitado a implementar 2 recursos.

//É garantido que os números de telefone passados ​​para as rotinas estejam no formato NNN-NNN-NNNN, por exemplo, 212-515-9876 e não nulo.

//1. Analise um número de telefone
//Sua análise deve retornar 3 dados

//Uma indicação se o número tem um código de discagem de Nova York, ou seja. 212 como os 3 primeiros dígitos
//Uma indicação se o número é falso tendo 555 como código de prefixo nas posições 5 a 7 (numeração de 1)
//Os últimos 4 dígitos do número.

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        phoneNumber = phoneNumber.Replace("-", string.Empty);
        return (IsNewYork: phoneNumber.Substring(0, 3) == "212", IsFake: phoneNumber.Substring(3, 3) == "555", LocalNumber: phoneNumber.Substring(6));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}