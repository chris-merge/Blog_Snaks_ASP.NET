 <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog_Snaks_UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

    <!--codigo css-->
    <style>
       
        .Image1{
            height:200px;
            width:300px;
            padding:2rem 4px;
        }
        #Cont_Imgs{
            border:2px solid red;
            margin:5rem auto;
            padding:25px 5px;
            height:500px;
        }
        .btm_Next{
            cursor:pointer;
        }
    </style>
    <!--titulo-->
    <br />
    <br />
        <h1 id="title">Bienvenido A los mejores Snaks Del Mundo!!</h1>
        <!--Mision y Vision de la empresa-->
        <section id="M_V">
            <div id="Mision">
                <h1>Mision</h1>
                <p>
                   Lorem ipsum dolor, sit, amet consectetur adipisicing elit. Aperiam,
                    repudiandae tempore aspernatur repellat totam obcaecati magni accusantium
                    exercitationem consequatur voluptatibus illum quae ipsa praesentium debitis
                    quam est! Corrupti perferendis, cupiditate!
                </p>
            </div>

            <div id="Vision">
                <h1>Vision</h1>
                <p>
                   Lorem ipsum dolor, sit, amet consectetur adipisicing elit. Aperiam,
                    repudiandae tempore aspernatur repellat totam obcaecati magni accusantium
                    exercitationem consequatur voluptatibus illum quae ipsa praesentium debitis
                    quam est! Corrupti perferendis, cupiditate!
                </p>
            </div>
        </section>
        <!---->
        <!--Imgs de asp -->
    <div id="Cont_Imgs">
        <div class="btm_Next" onclick="carrucel()">&#60</div>
        <div class="btm_After">&#62</div>
        <asp:Image  CssClass="Image1" ID="Image1" runat="server" src="Imgs/1.jpg"   />
    </div> 
      <!---->
    <img id="Image2" src="#" alt="Alternate Text" />
    <script>
        function carrucel() {
            document.getElementById("Image2").src = "Imgs/3.jpg";

        }
    </script>
    </asp:Content>

