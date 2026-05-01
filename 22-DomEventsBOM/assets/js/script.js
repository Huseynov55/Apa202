const body = document.body;
body.style.margin = "0";
body.style.display = "flex";
body.style.justifyContent = "center";
body.style.alignItems = "center";
body.style.height = "100vh";
body.style.backgroundColor = "#eef2f3";
body.style.fontFamily = "'Segoe UI', Roboto, sans-serif";


const card = document.createElement("div");
card.style.width = "380px";
card.style.backgroundColor = "#fff";
card.style.borderRadius = "12px";
card.style.boxShadow = "0 15px 35px rgba(0,0,0,0.1)";
card.style.overflow = "hidden";
card.style.position = "relative";


const topSection = document.createElement("div");
topSection.style.position = "relative";
topSection.style.height = "240px";

const houseImg = document.createElement("img");
houseImg.src = "https://images.unsplash.com/photo-1512917774080-9991f1c4c750?auto=format&fit=crop&w=800&q=80";
houseImg.style.width = "100%";
houseImg.style.height = "100%";
houseImg.style.objectFit = "cover";

const heartBtn = document.createElement("div");
heartBtn.innerHTML = "&#9825;";
heartBtn.style.position = "absolute";
heartBtn.style.top = "15px";
heartBtn.style.right = "15px";
heartBtn.style.color = "#fff";
heartBtn.style.fontSize = "24px";
heartBtn.style.cursor = "pointer";

topSection.append(houseImg, heartBtn);

const mainContent = document.createElement("div");
mainContent.style.padding = "20px";

const typeLabel = document.createElement("div");
typeLabel.innerText = "DETACHED HOUSE • 5Y OLD";
typeLabel.style.color = "#5a6b82";
typeLabel.style.fontSize = "12px";
typeLabel.style.fontWeight = "800";
typeLabel.style.letterSpacing = "0.5px";
typeLabel.style.marginBottom = "8px";

const priceTag = document.createElement("h1");
priceTag.innerText = "$750,000";
priceTag.style.margin = "0";
priceTag.style.fontSize = "32px";
priceTag.style.color = "#2d3436";

const addressText = document.createElement("p");
addressText.innerText = "742 Evergreen Terrace";
addressText.style.color = "#636e72";
addressText.style.fontSize = "15px";
addressText.style.marginTop = "4px";
addressText.style.marginBottom = "20px";


const detailsRow = document.createElement("div");
detailsRow.style.display = "flex";
detailsRow.style.gap = "25px";
detailsRow.style.paddingTop = "15px";
detailsRow.style.borderTop = "1px solid #f1f1f1";

const bedInfo = document.createElement("div");
bedInfo.innerHTML = `<span style="font-size: 18px;">🛏️</span> <b style="color:#2d3436">3</b> <span style="color:#636e72">Bedrooms</span>`;

const bathInfo = document.createElement("div");
bathInfo.innerHTML = `<span style="font-size: 18px;">🛁</span> <b style="color:#2d3436">2</b> <span style="color:#636e72">Bathrooms</span>`;

detailsRow.append(bedInfo, bathInfo);
mainContent.append(typeLabel, priceTag, addressText, detailsRow);


const footer = document.createElement("div");
footer.style.padding = "15px 20px";
footer.style.backgroundColor = "#f9fbff";
footer.style.display = "flex";
footer.style.alignItems = "center";
footer.style.gap = "12px";


const agentAvatar = document.createElement("img");
agentAvatar.src = "https://i.pravatar.cc/150?u=tiffany";
agentAvatar.style.width = "45px";
agentAvatar.style.height = "45px";
agentAvatar.style.borderRadius = "50%";
agentAvatar.style.border = "2px solid #fff";


const agentDetails = document.createElement("div");
const agentName = document.createElement("div");
agentName.innerText = "Tiffany Heffner";
agentName.style.fontWeight = "700";
agentName.style.fontSize = "14px";

const agentPhone = document.createElement("div");
agentPhone.innerText = "(555) 555-4321";
agentPhone.style.fontSize = "12px";
agentPhone.style.color = "#7f8c8d";

agentDetails.append(agentName, agentPhone);
footer.append(agentAvatar, agentDetails);


card.append(topSection, mainContent, footer);
body.appendChild(card);


heartBtn.onclick = () => {
    heartBtn.innerHTML = heartBtn.innerHTML === "♡" ? "❤️" : "♡";
};