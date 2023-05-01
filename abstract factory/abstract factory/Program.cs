// See https://aka.ms/new-console-template for more information
using abstract_factory.NewFolder;
using abstract_factory.RealLife;
using abstract_factory.structure;

/*AbstractFactory concreteFactory1 = new ConcreteFactory1();
Client client1 = new Client(concreteFactory1);
client1.run();

AbstractFactory concreteFactory2 = new ConcreteFactory2();
Client client2 = new Client(concreteFactory2);
client2.run();*/

testReal();

Console.ReadLine();


void testStructure(){
    AbstractFactory concreteFactory1 = new ConcreteFactory1();
    Client client1 = new Client(concreteFactory1);
    client1.run();

    AbstractFactory concreteFactory2 = new ConcreteFactory2();
    Client client2 = new Client(concreteFactory2);
    client2.run();
}

void testReal()
{
    CutTheChase<AfricaFactory>();
    CutTheChase<EuropeFactory>();
}

void CutTheChase<T>() where T : ContinentFactory, new()
{
    ContinentFactory continent = new T();
    continentClient client2 = new continentClient(continent);
    client2.runWild();
}