import { showLoading } from "./loading.js";
import { loadView, updateElement } from "./fetchView.js";

const main = async () => {
	showLoading(false);

	$("#nav-financInfo").click(async () => updateElement("#container", await loadView("/financinfo")));
	$("#nav-fileInfo").click(async () => updateElement("#container", await loadView("/fileinfo")));
	$("#container").on("click", "#financialReport", async () =>
		updateElement("#finance-info-container", await loadView("/FinancInfo/FinancialReport"))
	);
	$("#container").on("click", "#stepPayments", async () =>
		updateElement("#finance-info-container", await loadView("/FinancInfo/StepPayments"))
	);

	$("#container").on("click", "#DisabledCredentials", async () =>
		updateElement("#file-info-container", await loadView("/FileInfo/DisabledCredentials"))
	);
	$("#container").on("click", "#Profile", async () =>
		updateElement("#file-info-container", await loadView("/FileInfo/ProfileInfo"))
	);
};

$(document).ready(async function () {
	await main();
});
