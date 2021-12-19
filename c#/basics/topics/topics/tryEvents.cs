namespace Topics
{
    public delegate void ShapeChange(object source, ShapeEventArgs args);

    public class ShapeEventArgs : EventArgs 
    {
        public double NewArea {get;}

        public ShapeEventArgs(double area)
        {
            NewArea = area;
        }
    }

    public abstract class Shape
    {
        public double Area {get; set;}
        public event ShapeChange ShapeChanged;

        // abstract method do not provide an implementation and force the derived classes to override the method.
        public abstract void Draw();

        // Virtual methods have an implementation and provide the derived classes with the option of overriding it.
        protected virtual void onShapeCanged(ShapeEventArgs e)
        {
            if(ShapeChanged != null){
                ShapeChanged(this, e);
            }
        }
    }

    public class Circle : Shape 
    {

        public override void Draw()
        {
            System.Console.WriteLine("drawing circle");
        }

        public void updateCircle(double newRadius)
        {
            Area = (3.14 * newRadius * newRadius);

            base.onShapeCanged(new ShapeEventArgs(Area));
        }
    }

    public class Rectangle : Shape 
    {
        public override void Draw()
        {
            System.Console.WriteLine("drawing rectangle");
        }

        public void updateRectangle(int l, int b)
        {
            Area = l*b;

            onShapeCanged(new ShapeEventArgs(Area));
        }

        protected override void onShapeCanged(ShapeEventArgs e){
            base.onShapeCanged(new ShapeEventArgs(Area));
        }
    }

    public class ShapeContainer
    {
        private List<Shape> shapeList;

        public ShapeContainer(){
            shapeList = new List<Shape>();
        }

        private void HandleShapeChanged(object o, ShapeEventArgs e){
            if(o is Shape s){
                System.Console.WriteLine($"received event, shape area: {e.NewArea}");
                s.Draw();
            }
        }

        public void AddShape(Shape s){
            shapeList.Add(s);
            s.ShapeChanged += HandleShapeChanged;
        }
    }
}
