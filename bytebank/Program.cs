using bytebank;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "andré silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Nome do titular da conta: " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "andré silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;

//Console.WriteLine("Nome do titular da conta: " + contaDoAndre2.saldo);

//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre == contaDoAndre2);


//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da conta do André pós depósito = " + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André pós saque = " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para o saque.");
//}

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da maria: " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Souza";
//Console.WriteLine("Nome do titular da conta: " + contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);


Cliente cliente = new Cliente();
cliente.nome = "Andre Silva";
cliente.cpf = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010 - x";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular: "+ conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("profissão: " + conta.titular.profissao);
Console.WriteLine("Número da conta: " + conta.conta);
Console.WriteLine("Agência: " + conta.numero_agencia);
Console.WriteLine("Saldo: " + conta.saldo);