// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
	const loadView = (url) => {
		$.ajax({
			url: url,
			type: "GET",
			cache: false,
		}).done(function (result) {
			updateRootElement(result);
		});
	};
	const updateRootElement = (view) => {
		$("#root").html(view);
	};

	$(function () {
		$("#nav-financInfo").click(() => loadView("/financinfo"));
		$("#nav-fileInfo").click(() => loadView("/fileinfo"));
		$("#DisabledCredentials").click(() => loadView("/fileinfo/DisabledCredentials"));
		$("#financialReport").click(() => loadView("/financInfo/FinancialReport"));
	});

	$(".loader")
		.hide() // Hide it initially
		.ajaxStart(function () {
			$(this).show();
		})
		.ajaxStop(function () {
			$(this).hide();
		});
});
