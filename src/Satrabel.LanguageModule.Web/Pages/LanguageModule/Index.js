$(function () {
    // Assuming l is a function for localization, replace or implement as needed.
    var l = abp.localization.getResource('LanguageModule');

    var createModal = new abp.ModalManager(abp.appPath + 'LanguageModule/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'LanguageModule/EditModal');


    var defaultLanguage;
    satrabel.languageModule.languages.language.getDefaultLanguage().then(function (response) {
        // Assuming response contains the culture name of the default language
        defaultLanguage = response; // Store the default language

        
    });

    var dataTable = $('#LanguageTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        serverSide: true,
        paging: true,
        order: [[1, "asc"]],
        searching: false,
        scrollX: true,
        ajax: abp.libs.datatables.createAjax(satrabel.languageModule.languages.language.getList),
        columnDefs: [
            {
                title: l('Actions'),
                rowAction: {
                    items: [
                        {
                            
                            text: l('Edit'),
                            visible: abp.auth.isGranted('LanguageModule.Language.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                
                        },
                        {
                            text: l('Delete'),
                            visible: abp.auth.isGranted('LanguageModule.Language.Delete'),
                            confirmMessage: function (data) {
                                return l('LanguageDeletionConfirmationMessage', data.record.name); // Ensure you're passing the correct identifier or name for confirmation.
                            },
                            action: function (data) {
                                satrabel.languageModule.languages.language['delete'](data.record.id)
                                    .then(function () {
                                        abp.notify.info(l('SuccessfullyDeleted'));
                                        dataTable.ajax.reload();
                                    })
                                    .catch(function (error) {
                                        abp.notify.error(l('DeletionFailed'));
                                        console.error("Deletion error:", error);
                                    });
                            }
                        },
                        {
                            text: l('SetDefault'),
                            visible: abp.auth.isGranted('LanguageModule.Language.SetDefault'),
                            confirmMessage: function (data) {
                                return l('ChangeDefaultLanguageConfirmationMessage', data.record.name); // Ensure you're passing the correct identifier or name for confirmation.
                            },
                            action: function (data) {
                                satrabel.languageModule.languages.language.setDefaultLanguage(data.record.cultureName)

                                    .then(function () {
                                        abp.notify.info(l('DefaultLanguageChanged'));
                                        defaultLanguage = data.record.cultureName;
                                        dataTable.ajax.reload();
                                    })
                                    .catch(function (error) {
                                        abp.notify.error(l('ChangeDefaultLanguageFailed'));
                                        console.error("Change default language error:", error);
                                    });
                            }
                        }
                    ]
                }
            },
            { title: l('CultureName'), data: "cultureName" },
            { title: l('UiCultureName'), data: "uiCultureName" },
            { title: l('DisplayName'), data: "displayName" },
            { title: l('FlagIcon'), data: "flagIcon" },
            {
                title: l('DefaultLanguage'), 
                data: null, 
                render: function (data, type, row, meta) {
                    
                    return row.cultureName === defaultLanguage ? l('trueStandardLanguage') : '';
                }
            }
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewLanguageButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
