namespace Urbas.Example.Bar {
  public class Bar {
    public string Message {
      get { return "I am Bar! And I know " + new Foo.Foo().Message; }
    }
  }
}