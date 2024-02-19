$(document).ready(function () {
    ShowCount();

    $('body').on('click', '.btnAddToCart', function (e) {
        e.preventDefault();
        var id = $(this).data('id');

        var quatity = 1;
        var tQuantity = $('#quantity_value').text();
        if (tQuantity != '') {
            quatity = parseInt(tQuantity);
        }

        alert(id + " " + quatity);
        $.ajax({
            url: "/Shoppingcart/addtocart",
            type: 'POST',
            data: { id: id, quantity: quatity },
            success: function (rs) {
                if (rs.Success) {
                    $('#checkout_items').html(rs.Count);
                    alert(rs.msg);
                }
            }
        })
    })
})

function ShowCount() {
    $.ajax({
        url: "/Shoppingcart/ShowCount",
        type: 'GET',
        success: function (rs) {
            $('#checkout_items').html(rs.Count);
        }
    })
}