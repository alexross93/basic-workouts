@Code
    ViewData("Title") = "Home Page"
End Code
<head>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.13/css/all.css" integrity="sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp"
          crossorigin="anonymous">
</head>
<div class="row">
    <div class="col-md-4">
        <h2>My workouts</h2>
    </div>

    <table class="table table-bordered table-responsive table-hover table-striped">
        <tr>
            <th>Order</th>
            <th>Title (En)</th>
            <th>Title (Fr)</th>
            <th>Action</th>

        </tr>
        <tr id="row1">
            <th>1</th>
            <td>Production Title</td>
            <td>Titre de Production</td>
            <td>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="showTable1()">
                    <i class="fa fa-edit"></i>
                </a>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="hideRow1()">
                    <i class="fa fa-trash"></i>
                </a>
            </td>
        </tr>
        <tr id="row2">
            <th>2</th>
            <td>Past Productions</td>
            <td>Production Historique</td>
            <td>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="showTable2()">
                    <i class="fa fa-edit"></i>
                </a>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="hideRow2()">
                    <i class="fa fa-trash"></i>
                </a>
            </td>
        </tr>
    </table>

    <table id="table1" style="display:none;" class="table table-bordered table-responsive table-hover table-striped">
        <tr>
            <th>Order</th>
            <th>Title (En)</th>
            <th>Title (Fr)</th>
            <th>Action</th>

        </tr>
        <tr id="row01">
            <th>1</th>
            <td>Production Cycle</td>
            <td>Cycle de Production</td>
            <td>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="hideRow01()">
                    <i class="fa fa-trash"></i>
                </a>
            </td>
        </tr>
        <tr id="row02">
            <th>2</th>
            <td>Past Productions</td>
            <td>Production Historique</td>
            <td>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="hideRow02()">
                    <i class="fa fa-trash"></i>
                </a>
            </td>
        </tr>
        <tr id="row03">
            <th>2</th>
            <td>Date</td>
            <td>Le Date</td>
            <td>
                <a href="javascript:void(0)" class="btn-floating btn-small blue" onclick="hideRow03()">
                    <i class="fa fa-trash"></i>
                </a>
            </td>
        </tr>
    </table>

    <script>
        function showTable1() {
            //document.getElementsByClassName("row").style.display = "none";
            document.getElementById('table1').style.display = "block";
        }

        function showTable2() {
            document.getElementById('table2').style.display = "block";
        }

        function hideRow1() {
            document.getElementById('row1').style.display = "none";
        }

        function hideRow2() {
            document.getElementById('row2').style.display = "none";
        }

        function hideRow01() {
            document.getElementById('row01').style.display = "none";
        }

        function hideRow02() {
            document.getElementById('row02').style.display = "none";
        }

        function hideRow03() {
            document.getElementById('row03').style.display = "none";
        }

    </script>
</div>
