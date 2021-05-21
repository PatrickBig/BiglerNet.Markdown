// Gets information about the currently selected text.
window.getSelectedTextInformation = () => {
    var textArea = document.activeElement;

    var response = new Object();

    response.SelectionStart = textArea.selectionStart;
    response.SelectionEnd = textArea.selectionEnd;
    response.SelectedText = textArea.value.substring(response.SelectionStart, response.SelectionEnd);

    return response;
}
