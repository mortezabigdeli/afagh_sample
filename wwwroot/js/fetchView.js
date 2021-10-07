import { showLoading } from "./loading.js";
export const loadView = async (url) => {
	try {
		showLoading();
		return await $.ajax({
			url: url,
			type: "GET",
			cache: false,
		});
	} catch (error) {
		return error;
	} finally {
		showLoading(false);
	}
};

export const updateElement = (element, view) => {
	$(element).html(view);
};
