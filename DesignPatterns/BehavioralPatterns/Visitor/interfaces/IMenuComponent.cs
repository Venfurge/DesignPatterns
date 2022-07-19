namespace Visitor.interfaces
{
    internal interface IMenuComponent
    {
        public void AcceptVisitor(IVisitor visitor);
    }
}
