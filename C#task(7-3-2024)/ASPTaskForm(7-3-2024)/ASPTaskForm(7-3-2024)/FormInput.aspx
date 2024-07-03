<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormInput.aspx.cs" Inherits="ASPTaskForm_7_3_2024_.FormInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!-- Bootstrap CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <style>
        tr {
            display: inline;
        }

        .gradient-custom {
            /* fallback for old browsers */
            background: #f093fb;
            /* Chrome 10-25, Safari 5.1-6 */
            background: -webkit-linear-gradient(to bottom right, rgba(240, 147, 251, 1), rgba(245, 87, 108, 1));
            /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
            background: linear-gradient(to bottom right, rgba(240, 147, 251, 1), rgba(245, 87, 108, 1));
        }

        .inlineRadio, form-check {
            display: inline;
        }


        .card-registration .select-input.form-control[readonly]:not([disabled]) {
            font-size: 1rem;
            line-height: 2.15;
            padding-left: .75em;
            padding-right: .75em;
        }

        .card-registration .select-arrow {
            top: 13px;
        }
        .form-check-input {
            width:10rem;
        }
    </style>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100 gradient-custom">
            <div class="container py-5 h-100">
                <div class="row justify-content-center align-items-center h-100">
                    <div class="col-12 col-lg-9 col-xl-7">
                        <div class="card shadow-2-strong card-registration" style="border-radius: 15px;">
                            <div class="card-body p-4 p-md-5">
                                <h3 class="mb-4 pb-2 pb-md-0 mb-md-5">Registration Form</h3>

                     
                                <div class="row">
                                    <div class="col-md-12">
                                        <div data-mdb-input-init class="form-outline">
                                            <asp:Label runat="server" AssociatedControlID="firstName" CssClass="form-label">Full name:</asp:Label>
                                            <asp:TextBox runat="server" ID="firstName" CssClass="form-control form-control-lg"></asp:TextBox>

                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-12 d-flex align-items-center">
                                        <div data-mdb-input-init class="form-outline datepicker w-100">
                                            <asp:Label runat="server" AssociatedControlID="InputID" CssClass="form-label">ID</asp:Label>
                                            <asp:TextBox runat="server" ID="InputID" CssClass="form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12 d-flex align-items-center">
                                        <div data-mdb-input-init class="form-outline datepicker w-100">
                                            <asp:Label runat="server" AssociatedControlID="InputEmail" CssClass="form-label">Email</asp:Label>
                                            <asp:TextBox runat="server" ID="InputEmail" CssClass="form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-4 d-flex align-items-center">
                                        <h6 class="mb-2 pb-1">Gender: </h6>
                                        <asp:RadioButtonList runat="server" ID="genderList" CssClass="form-check d-flex">
                                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                            <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-md-6 mb-4 d-flex align-items-center">
                                    <h6 class="mb-2 pb-1">Subjects:</h6>
                                   
                                        <asp:CheckBoxList ID="CheckBoxListSubjects" runat="server" CssClass="form-check-input">
                                            <asp:ListItem Text="c" Value="C"></asp:ListItem>
                                            <asp:ListItem Text="C++" Value="C++"></asp:ListItem>
                                            <asp:ListItem Text="C#" Value="C#"></asp:ListItem>
                                        </asp:CheckBoxList>
                                   
                                </div>
                            </div>

                            <div class="mt-4 pt-2">
                                <asp:Button runat="server" ID="submitButton" Text="Submit" CssClass="btn btn-primary btn-lg" OnClick="submitButton_Click" />
                            </div>

                        </div>
                    </div>
                </div>
            </div>
           
       
        </section>
        <div>
        <h4>Form Data:</h4>
        <ul>
            <li><strong>Name:</strong> <asp:Label ID="NameFrom" runat="server" /></li>
            <li><strong>Email:</strong> <asp:Label ID="EmailForm" runat="server" /></li>
            <li><strong>ID:</strong> <asp:Label ID="IDForm" runat="server" /></li>
            <li><strong>Gender:</strong> <asp:Label ID="GenderFrom" runat="server" /></li>
            <li><strong>Courses:</strong> <asp:Label ID="SubjectsForm" runat="server" /></li>
        </ul>
    </div>
    </form>
</body>
</html>
