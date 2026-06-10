using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Важно: добавляет поддержку продвинутой графики

namespace YourProjectName // Убедитесь, что здесь указано имя ВАШЕГО проекта
{
    // Наследуемся от стандартной кнопки Button
    public class RoundButton : Button
    {
        // Конструктор, где мы задаем начальные "CSS-подобные" свойства
        // Свойство для регулирования радиуса скругления (как border-radius в CSS)
        public int BorderRadius { get; set; } = 10;

        public RoundButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            this.BackColor = Color.FromArgb(52, 152, 219); // #3498db
            this.ForeColor = Color.White;

            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Cursor = Cursors.Hand;

            this.Size = new Size(258, 23);
            this.Text = "Войти";
        }

        // Вспомогательный метод для создания скругленного контура (GraphicsPath)
        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            // Верхний левый угол
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            // Верхний правый угол
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            // Нижний правый угол
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            // Нижний левый угол
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Переопределяем метод отрисовки кнопки
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Включаем Антиалиасинг (сглаживание), чтобы края не были "зубчатыми"
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;

            // Создаем контур скругления
            using (GraphicsPath pathSurface = GetRoundPath(rectSurface, BorderRadius))
            {
                // 1. Обрезаем окно кнопки по этому контуру (чтобы клики за пределами круга не срабатывали)
                this.Region = new Region(pathSurface);

                // 2. Заливаем фон текущим цветом кнопки
                using (SolidBrush brushBackground = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillPath(brushBackground, pathSurface);
                }
            }

            // 3. Рисуем текст строго по центру
            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                rectSurface,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        // Анимация при наведении (как псевдокласс :hover в CSS)
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(102, 192, 250); // Темно-синий
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.FromArgb(52, 152, 219); // Возвращаем исходный
        }
    }
}