(function ($) {

	'use strict';

	// ------------------------------------------------------- //
	// Auto Hide
	// ------------------------------------------------------ //	

	$(function () {
		$('#sorting-table').DataTable({
			"lengthMenu": [
				[5, 10, 15, -1],
				[5, 10, 15, "All"]
			],
			"order": [
				[3, "desc"]
			]
		});
	});

	$(function () {
		$('#export-table').DataTable({
			dom: 'Bfrtip',
			buttons: {
				buttons: [{
					extend: 'copy',
					text: 'کپی',
					title: $('h1').text(),
					exportOptions: {
						columns: ':not(.no-print)'
					},
					footer: true
				},{
					extend: 'excel',
					text: 'فایل Excel',
					title: $('h1').text(),
					exportOptions: {
						columns: ':not(.no-print)'
					},
					footer: true
				},{
					extend: 'csv',
					text: 'فایل Csv',
					title: $('h1').text(),
					exportOptions: {
						columns: ':not(.no-print)'
					},
					footer: true
				},{
					extend: 'pdf',
					text: 'فایل Pdf',
					title: $('h1').text(),
					exportOptions: {
						columns: ':not(.no-print)'
					},
					footer: true
				},{
					extend: 'print',
					text: 'پرینت',
					title: $('h1').text(),
					exportOptions: {
						columns: ':not(.no-print)'
					},
					footer: true,
					autoPrint: true
				}],
				dom: {
					container: {
						className: 'dt-buttons'
					},
					button: {
						className: 'btn btn-primary'
					}
				}
			}
		});
	});

})(jQuery);