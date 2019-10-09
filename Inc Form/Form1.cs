using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inc_Form
{
    public partial class incForm : Form
    {
        ComboBox comboBoxSubCategory1;
        ComboBox comboBoxSubCategory2;
        string categoryItem;
        string selectedCategory2;
        XElement ticketDetails;

        public incForm()
        {
            InitializeComponent();
            comboBoxSubCategory1 = subcategory1;
            comboBoxSubCategory2 = subcategory2;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Get all inbox input
            string usrRequestingService = username.Text;
            string requestTitle = incidentTitle.Text;
            string computerNameInput = computerName.Text;
            string categoryInput = category.Text;
            string subcategory1Input = subcategory1.Text;
            string subcategory2Input = subcategory2.Text;
            string shortDescriptionInput = description.Text;
            string resolutionTextInput = resolutionText.Text;
            string resolutionCode = resolvedCategory.Text;
            string resolvedBy = resolvedByInput.Text;
            bool isResolvedInput = resolved.Checked;
            

            string[] resolutionCodes = GetResolutionCodes(resolutionCode);

            if (isResolvedInput)
            {
                ticketDetails =
                            new XElement("Ticket",
                            new XElement("usr", usrRequestingService),
                            new XElement("computerName", computerNameInput),
                            new XElement("requestTitle", requestTitle),
                            new XElement("description", shortDescriptionInput),
                            new XElement("category", categoryInput),
                            new XElement("sub-category", subcategory1Input),
                            new XElement("sub-category2", subcategory2Input),
                            new XElement("isResolved", isResolvedInput),
                            new XElement("resolution", resolutionTextInput),
                            new XElement("causecodePrimary", resolutionCodes[0]),
                            new XElement("causeCodeSub1", resolutionCodes[1]),
                            new XElement("resolutionCode", resolutionCodes[2]),
                            new XElement("closureReason", "Resolved"),
                            new XElement("resolvedBy", resolvedBy));
            }

            if (!isResolvedInput)
            {
                ticketDetails =
                            new XElement("Ticket",
                            new XElement("usr", usrRequestingService),
                            new XElement("computerName", computerNameInput),
                            new XElement("requestTitle", requestTitle),
                            new XElement("description", shortDescriptionInput),
                            new XElement("category", categoryInput),
                            new XElement("sub-category", subcategory1Input),
                            new XElement("sub-category2", subcategory2Input),
                            new XElement("isResolved", isResolvedInput));
            }

            Random random = new Random();
            int num = random.Next();

            string winUsrName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();
            string folderPath = @winUsrName + "\\inc-ticket";
            checkForFolder(folderPath);
            string path = folderPath + "\\inc-ticket" + num + ".xml";
            ticketDetails.Save(path);
            clearInputs();


        }

        private string[] GetResolutionCodes(string resolutionCode)
        {
            string[] resolutionCodes;
            if (resolutionCode == "Information/advice given")
            {
                resolutionCodes = new string[] {
                        "Human",
                        "Knowledge Client",
                        "Information/advice given"
                    };
                return resolutionCodes;
            }

            if( resolutionCode == "Application repaired")
            {
                resolutionCodes = new string[]
                {
                    "Configuration",
                    "Application",
                    "Repaired"
                };
                return resolutionCodes;
            }

            if( resolutionCode == "Account settings updated")
            {
                resolutionCodes = new string[]
                {
                    "AccountSettings",
                    "Client",
                    "Amended/updated"
                };
                return resolutionCodes;
            }

            if( resolutionCode == "Unable to find fault")
            {
                resolutionCodes = new string[]
                {
                    "Other",
                    "Unable to find fault",
                    "No action taken",
                };
                return resolutionCodes;
            }

            if( resolutionCode == "Hardware failure")
            {
                resolutionCodes = new string[]
                {
                    "Hardware",
                    "Failure",
                    "Replaced"
                };
                return resolutionCodes;
            }
            return null;
        }

        private void clearInputs()
        {
            subcategory1.Items.Clear();
            subcategory1.Text = "";
            subcategory2.Items.Clear();
            subcategory2.Text = "";
            username.Clear();
            resolved.Checked = false;
            incidentTitle.Clear();
            computerName.Clear();
            description.Clear();
            resolutionText.Clear();
        }

        private void checkForFolder(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                //Fail silently.
            }
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform logic upon user selection change of category
            categoryItem = (string)category.SelectedItem;
            populateSubCategory1(categoryItem);
        }

        private void populateSubCategory1(string selectedCategory)
        {
            comboBoxSubCategory1.Items.Clear();

            switch (selectedCategory)

            {
                case "Application":

                    string[] appSubCategory1 = new string[] {
                        "BusApps",
                        "Bitlocker",
                        "FileSystem",
                        "Google",
                        "Microsoft",
                        "Salesforce",
                        "SharePoint",
                        "VPN Client",
                        "Webex"
                    };

                    addItemsToCombox(appSubCategory1, comboBoxSubCategory1);
                    break;
                case "DataCenter":

                    string[] dataCenterSubCategory1 = new string[] {
                        "System Support"
                    };

                    addItemsToCombox(dataCenterSubCategory1, comboBoxSubCategory1);
                    break;

                case "Messaging":

                    string[] messagingSubCategory1 = new string[] {
                      "Exchange"
                    };

                    addItemsToCombox(messagingSubCategory1, comboBoxSubCategory1);
                    break;

                case "Network":

                    string[] networkSubCategory1 = new string[] {
                        "Firewall",
                        "Generic",
                        "LAN",
                        "LANDataCenter",
                        "LANWireless",
                        "Proxy"
                    };

                    addItemsToCombox(networkSubCategory1, comboBoxSubCategory1);
                    break;

                case "Security Management":

                    string[] securityManagementSubCategory1 = new string[] {
                        "Information Security",
                        "Proxy"
                    };

                    addItemsToCombox(securityManagementSubCategory1, comboBoxSubCategory1);
                    break;

                case "Server Management":

                    string[] serverManagementSubCategory1 = new string[] {
                        "Linux",
                        "Windows"
                    };

                    addItemsToCombox(serverManagementSubCategory1, comboBoxSubCategory1);
                    break;
                case "Service Desk":

                    string[] serviceDeskSubCategory1 = new string[] {
                        "Internal"
                    };

                    addItemsToCombox(serviceDeskSubCategory1, comboBoxSubCategory1);
                    break;

                case "Telephony":

                    string[] telephonySubCategory1 = new string[] {
                        "ContactCenter",
                        "Fax",
                        "CellPhone",
                        "Voice"
                    };

                    addItemsToCombox(telephonySubCategory1, comboBoxSubCategory1);
                    break;

                case "Tools":

                    string[] toolsSubCategory1 = new string[] {
                        "ServiceNow"
                    };

                    addItemsToCombox(toolsSubCategory1, comboBoxSubCategory1);
                    break;
                case "User Management":

                    string[] userManagementSubCategory1 = new string[] {
                        "Account",
                        "ActiveDirectory",
                        "IT-Shop",
                        "IAM",
                        "Permissions"
                    };

                    addItemsToCombox(userManagementSubCategory1, comboBoxSubCategory1);
                    break;
                case "Workplace":

                    string[] workplaceSubCategory1 = new string[] {
                        "ClientHardware",
                        "ClientImage",
                        "FileService",
                        "Internet-Access",
                        "ManagedClientDevice",
                        "VirtualDesktopInfrastructure",
                        "ClientUpdates",
                        "PrintServices",
                        "SD",
                        "UserApplicationManagement"
                    };

                    addItemsToCombox(workplaceSubCategory1, comboBoxSubCategory1);
                    break;
                default:
                    break;
            }
        }

        private void addItemsToCombox(string[] appSubCategory, ComboBox comboBox)
        {
            comboBox.Items.AddRange(appSubCategory);
        }

        private void populateSubCategory2(string selectedCategory)
        {
            comboBoxSubCategory2.Items.Clear();

            if (categoryItem == "Application")
            {
                switch (selectedCategory2)
                {
                    
                    case "BusApps":
                        System.Diagnostics.Debug.WriteLine("Bus apps switch");
                        string[] busAppsSubCategory2 = new string[] {
                            "DHC Vision",
                            "Matrix42",
                            "Teamcenter"
                        };
                        addItemsToCombox(busAppsSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Adobe":

                        string[] adobeSubCategory2 = new string[] {
                            "Adobe Flash Player",
                            "Adobe Reader"
                        };
                        addItemsToCombox(adobeSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Bitlocker":

                        string[] bitlockerSubCategory2 = new string[] {
                            "Account Unlock",
                            "Fault"
                        };
                        addItemsToCombox(bitlockerSubCategory2, comboBoxSubCategory2);
                        break;

                    case "FileSystem":

                        string[] fileSystemSubCategory2 = new string[] {
                            "unspecified"
                        };
                        addItemsToCombox(fileSystemSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Google":
                        string[] googleSubCategory2 = new string[] {
                            "Chrome"
                        };
                        addItemsToCombox(googleSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Microsoft":

                        string[] microsoftSubCategory2 = new string[] {
                            "O365",
                            "Access",
                            "Internet Explorer",
                            "Lync",
                            "MS Project",
                            "Office",
                            "Outlook",
                            "SkypeforBusiness"
                        };
                        addItemsToCombox(microsoftSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Salesforce":

                        string[] salesforceSubCategory2 = new string[] {
                            "Vertrieb",
                            "Service",
                            "Technik",
                            "Portal",
                            "Anmeldung",
                            "Tool Fileadmin",
                            "Tool Mobile Application",
                            "Salesforce App",
                            "SAP Verbindung",
                            "Other"
                        };
                        addItemsToCombox(salesforceSubCategory2, comboBoxSubCategory2);
                        break;

                    case "SharePoint":

                        string[] sharepointSubCategory2 = new string[] {
                            "Basis",
                            "EndUser Issue"
                        };
                        addItemsToCombox(sharepointSubCategory2, comboBoxSubCategory2);
                        break;

                    case "VPN Client":
                        string[] vpnClientSubCategory2 = new string[] {
                            "Other"
                         };
                        addItemsToCombox(vpnClientSubCategory2, comboBoxSubCategory2);
                        break;

                    case "Webex":

                        string[] webexSubCategory2 = new string[] {
                            "Other"
                        };
                        addItemsToCombox(webexSubCategory2, comboBoxSubCategory2);
                        break;
                }
            }

            if (categoryItem == "DataCenter")
            {
                string[] systemSupportSubCat2 = new string[] {
                            "Other"
                        };
                addItemsToCombox(systemSupportSubCat2, comboBoxSubCategory2);
            }

            if (categoryItem == "Messaging")
            {
                if(selectedCategory2 == "Lync-OCS")
                {
                    string[] lyncOCSSubCat2 = new string[] {
                            "Other",
                            "unspecified"
                        };
                    addItemsToCombox(lyncOCSSubCat2, comboBoxSubCategory2);
                }

                if(selectedCategory2 == "Mailbox")
                {
                    string[] mailboxSubCat2 = new string[] {
                           "Encryption",
                            "Other",
                            "Spam",
                            "Virus"
                        };
                    addItemsToCombox(mailboxSubCat2, comboBoxSubCategory2);
                }

                if (selectedCategory2 == "Exchange")
                {
                    string[] exchangeSubCat2 = new string[] {
                            "unspecified",
                            "Other"
                        };
                    addItemsToCombox(exchangeSubCat2, comboBoxSubCategory2);
                }

            }

            if (categoryItem == "Network")
            {
                switch (selectedCategory2)
                {
                    case "Firewall":
                        string[] firewallSubCat2 = new string[] {
                            "Event",
                            "General",
                            "unspecified"
                        };
                        addItemsToCombox(firewallSubCat2, comboBoxSubCategory2);
                        break;

                    case "Generic":
                        string[] genericSubCat2 = new string[] {
                            "unspecified",
                            "Event"
                        };
                        addItemsToCombox(genericSubCat2, comboBoxSubCategory2);
                        break;

                    case "LAN":
                        string[] lanSubCat2 = new string[] {
                            "LoadBalancer-General"
                        };
                        addItemsToCombox(lanSubCat2, comboBoxSubCategory2);
                        break;

                    case "LANWireless":
                        string[] lanWifiSubCat2 = new string[] {
                            "unspecified",
                            "Connectivity",
                            "Event",
                            "General",
                            "Performance"
                        };
                        addItemsToCombox(lanWifiSubCat2, comboBoxSubCategory2);
                        break;

                    case "Proxy":
                        string[] proxySubCat2 = new string[] {
                            "Other"
                        };
                        addItemsToCombox(proxySubCat2, comboBoxSubCategory2);
                        break;

                    case "RemoteAccess":
                        string[] remoteAccessSubCat2 = new string[] {
                            "Event"
                        };
                        addItemsToCombox(remoteAccessSubCat2, comboBoxSubCategory2);
                        break;
                }
            }

            if (categoryItem == "Security Management")
            {
                if(selectedCategory2 == "Information Security")
                {
                    string[] remoteAccessSubCat2 = new string[] {
                            "General"
                        };
                    addItemsToCombox(remoteAccessSubCat2, comboBoxSubCategory2);
                }

                if(selectedCategory2 == "Proxy")
                {
                    string[] proxySubCat2 = new string[] {
                            "Other"
                        };
                    addItemsToCombox(proxySubCat2, comboBoxSubCategory2);
                }
            }

            if (categoryItem == "Server Management")
            {
                if(selectedCategory2 == "Linux")
                {
                    string[] linuxSubCat2 = new string[] {
                            "SMA-supported",
                            "Notify",
                            "unspecified",
                            "Other"
                        };
                    addItemsToCombox(linuxSubCat2, comboBoxSubCategory2);
                }

                if(selectedCategory2 == "Windows")
                {
                    string[] windowsSubCat2 = new string[] {
                            "SMA-supported",
                            "Notify",
                            "unspecified",
                            "Other"
                        };
                    addItemsToCombox(windowsSubCat2, comboBoxSubCategory2);
                }
            }

            if (categoryItem == "Service Desk")
            {
                if(selectedCategory2 == "Internal")
                {
                    string[] internalSubCat2 = new string[] {
                            "Others"
                        };
                    addItemsToCombox(internalSubCat2, comboBoxSubCategory2);
                }
            }

            if (categoryItem == "Telephony")
            {
                if(selectedCategory2 == "ContactCenter")
                {
                    string[] contactCenterSubCat2 = new string[] {
                            "CRM",
                            "Mail",
                            "Other",
                            "Phone"
                        };
                    addItemsToCombox(contactCenterSubCat2, comboBoxSubCategory2);
                }

                if (selectedCategory2 == "CellPhone")
                {
                    string[] cellphoneSubCat2 = new string[] {
                            "Hardware"
                        };
                    addItemsToCombox(cellphoneSubCat2, comboBoxSubCategory2);
                }

                if (selectedCategory2 == "Voice")
                {
                    string[] voiceSubCat2 = new string[] {
                            "DECT",
                            "Cisco",
                            "Video Conferencing"
                        };
                    addItemsToCombox(voiceSubCat2, comboBoxSubCategory2);
                }
            }

            if (categoryItem == "Tools")
            {
                if (selectedCategory2 == "ServiceNow")
                {
                    string[] servicenowSubCat2= new string[] {
                            "CMDB",
                            "Functional Issue",
                            "Knowledge Base",
                            "Reporting Service",
                            "Self Service",
                            "Login or Password",
                            "Patching",
                            "Release",
                            "Service Catalog",
                            "Technical Issue",
                            "Ticketing"
                        };
                    addItemsToCombox(servicenowSubCat2, comboBoxSubCategory2);
                }
            }

            if (categoryItem == "User Management")
            {
                switch (selectedCategory2)
                {
                    case "Account":
                        string[] accountSubCat2 = new string[] {
                            "Other"
                        };
                        addItemsToCombox(accountSubCat2, comboBoxSubCategory2);
                        break;
                    case "ActiveDirectory":
                        string[] activeDirectorySubCat2 = new string[] {
                            "AD Account Reset",
                            "Other"
                        };
                        addItemsToCombox(activeDirectorySubCat2, comboBoxSubCategory2);
                        break;
                    case "IT-Shop":
                        string[] itShopSubCat2 = new string[] {
                            "Approval",
                            "IT-Shop entry",
                            "other"
                        };
                        addItemsToCombox(itShopSubCat2, comboBoxSubCategory2);
                        break;
                    case "IAM":
                        string[] iamShopSubCat2 = new string[] {
                            "Interface",
                            "other"
                        };
                        addItemsToCombox(iamShopSubCat2, comboBoxSubCategory2);
                        break;
                    case "Permissions":
                        string[] permissionsSubCat2 = new string[] {
                            "Application systems",
                            "File system",
                            "Internet access",
                            "other",
                            "Roles"
                        };
                        addItemsToCombox(permissionsSubCat2, comboBoxSubCategory2);
                        break;
                }
            }

            if (categoryItem == "Workplace")
            {
                switch (selectedCategory2)
                {
                    case "ClientHardware":
                        string[] clientHardwareSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(clientHardwareSubCat2, comboBoxSubCategory2);
                        break;
                    case "ClientImage":
                        string[] clientImageSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(clientImageSubCat2, comboBoxSubCategory2);
                        break;
                    case "FileService":
                        string[] fileServicesSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(fileServicesSubCat2, comboBoxSubCategory2);
                        break;
                    case "Internet-Access":
                        string[] internetAccessSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(internetAccessSubCat2, comboBoxSubCategory2);
                        break;
                    case "ManagedClientDevice":
                        string[] managedClientDevicesSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(managedClientDevicesSubCat2, comboBoxSubCategory2);
                        break;
                    case "VirtualDesktopInfrastructure":
                        string[] vdiSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(vdiSubCat2, comboBoxSubCategory2);
                        break;
                    case "ClientUpdates":
                        string[] clientUpdatesSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(clientUpdatesSubCat2, comboBoxSubCategory2);
                        break;
                    case "PrintServices":
                        string[] printSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(printSubCat2, comboBoxSubCategory2);
                        break;
                    case "SD":
                        string[] sdSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(sdSubCat2, comboBoxSubCategory2);
                        break;
                    case "UserApplicationManagement":
                        string[] userAppsSubCat2 = new string[] {
                            "LabelPrinter",
                            "Scanner",
                            "Tablet",
                            "Desktop",
                            "Laptop",
                            "MobileDevice",
                            "Monitor",
                            "Other",
                            "Peripheral",
                            "Printer"
                        };
                        addItemsToCombox(userAppsSubCat2, comboBoxSubCategory2);
                        break;
                }
            }
        }

        private void Subcategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory2 = (string)subcategory1.SelectedItem;
            populateSubCategory2(selectedCategory2);
        }
    }
}