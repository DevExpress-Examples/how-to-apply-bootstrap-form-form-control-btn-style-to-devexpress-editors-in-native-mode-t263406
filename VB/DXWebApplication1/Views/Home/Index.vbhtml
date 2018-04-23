TextBox with Native="true" and CssClass="form-control" <b>(Bootstrap Design)</b>
@Html.DevExpress().TextBox( _
    Sub(settings)
            settings.Name = "TextBox1"
            settings.ControlStyle.CssClass = "form-control"
            settings.Properties.Native = True
            settings.Width = Unit.Pixel(200)
    End Sub).GetHtml()
<br />
Memo with Native="true" and CssClass="form-control" <b>(Bootstrap Design)</b>
@Html.DevExpress().Memo( _
    Sub(settings)
            settings.Name = "Memo1"
            settings.ControlStyle.CssClass = "form-control"
            settings.Properties.Native = True
            settings.Height = Unit.Pixel(100)
            settings.Width = Unit.Pixel(200)
    End Sub).GetHtml()
<br />
Button with Native="true" and CssClass="btn btn-primary" <b>(Bootstrap Design)</b>
<br />
@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "Button1"
            settings.ControlStyle.CssClass = "btn btn-primary"
            settings.Styles.Native = True
            settings.UseSubmitBehavior = True
            settings.Text = "Submit"
    End Sub).GetHtml()
<br />
<br />
TextBox with Theme="Moderno" <b>(DevExpress Design)</b>
@Html.DevExpress().TextBox( _
    Sub(settings)
            settings.Name = "TextBox2"
            settings.Width = Unit.Pixel(200)
    End Sub).GetHtml()
<br />
Memo with Theme="Moderno" <b>(DevExpress Design)</b>
@Html.DevExpress().Memo( _
    Sub(settings)
            settings.Name = "Memo2"
            settings.Height = Unit.Pixel(100)
            settings.Width = Unit.Pixel(200)
    End Sub).GetHtml()
<br />
Button with Theme="Moderno" <b>(DevExpress Design)</b>
<br />
@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "Button2"
            settings.UseSubmitBehavior = True
            settings.Text = "Submit"
    End Sub).GetHtml()