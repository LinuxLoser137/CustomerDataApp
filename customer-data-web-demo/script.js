const customers = [
  { company: "Alfreds Futterkiste", contact: "Maria Anders", city: "Berlin", country: "Germany" },
  { company: "Ana Trujillo Emparedados", contact: "Ana Trujillo", city: "México D.F.", country: "Mexico" },
  { company: "Around the Horn", contact: "Thomas Hardy", city: "London", country: "United Kingdom" },
  { company: "Berglunds Snabbköp", contact: "Christina Berglund", city: "Luleå", country: "Sweden" },
  { company: "Blauer See Delikatessen", contact: "Hanna Moos", city: "Mannheim", country: "Germany" },
  { company: "Bon app'", contact: "Laurence Lebihan", city: "Marseille", country: "France" },
  { company: "Bottom-Dollar Markets", contact: "Elizabeth Lincoln", city: "Tsawassen", country: "Canada" },
  { company: "Centro comercial Moctezuma", contact: "Francisco Chang", city: "México D.F.", country: "Mexico" },
  { company: "Chop-suey Chinese", contact: "Yang Wang", city: "Bern", country: "Switzerland" },
  { company: "Comércio Mineiro", contact: "Pedro Afonso", city: "São Paulo", country: "Brazil" },
  { company: "Consolidated Holdings", contact: "Elizabeth Brown", city: "London", country: "United Kingdom" },
  { company: "Drachenblut Delikatessen", contact: "Sven Ottlieb", city: "Aachen", country: "Germany" }
];

const countButton = document.querySelector("#countButton");
const namesButton = document.querySelector("#namesButton");
const lastNamesButton = document.querySelector("#lastNamesButton");
const resetButton = document.querySelector("#resetButton");
const customerCount = document.querySelector("#customerCount");
const customerResults = document.querySelector("#customerResults");
const statusMessage = document.querySelector("#statusMessage");
const searchInput = document.querySelector("#searchInput");

let currentMode = "none";
let currentRecords = [];

function createCustomerCard(customer, mode) {
  const card = document.createElement("article");
  card.className = "customer-card";

  const title = document.createElement("h3");
  title.textContent = mode === "lastNames"
    ? customer.contact.split(" ").slice(-1)[0]
    : customer.company;

  const contact = document.createElement("p");
  contact.textContent = `Contact: ${customer.contact}`;

  const location = document.createElement("p");
  location.textContent = `${customer.city}, ${customer.country}`;

  card.append(title, contact, location);
  return card;
}

function renderRecords(records = currentRecords) {
  customerResults.replaceChildren();

  if (currentMode === "count") {
    statusMessage.textContent = `The sample dataset contains ${customers.length} customer records.`;
    return;
  }

  if (records.length === 0 && currentMode !== "none") {
    statusMessage.textContent = "No matching customer records were found.";
    return;
  }

  records.forEach(customer => {
    customerResults.appendChild(createCustomerCard(customer, currentMode));
  });

  if (currentMode !== "none") {
    const label = currentMode === "lastNames" ? "contact last names" : "company names";
    statusMessage.textContent = `Showing ${records.length} ${label}.`;
  }
}

countButton.addEventListener("click", () => {
  currentMode = "count";
  currentRecords = [];
  customerCount.textContent = customers.length;
  searchInput.value = "";
  customerResults.replaceChildren();
  renderRecords();
});

namesButton.addEventListener("click", () => {
  currentMode = "names";
  currentRecords = [...customers];
  searchInput.value = "";
  renderRecords();
});

lastNamesButton.addEventListener("click", () => {
  currentMode = "lastNames";
  currentRecords = [...customers].sort((a, b) => {
    const aLast = a.contact.split(" ").slice(-1)[0];
    const bLast = b.contact.split(" ").slice(-1)[0];
    return aLast.localeCompare(bLast);
  });
  searchInput.value = "";
  renderRecords();
});

searchInput.addEventListener("input", event => {
  if (currentMode === "none" || currentMode === "count") {
    return;
  }

  const term = event.target.value.trim().toLowerCase();
  const filtered = currentRecords.filter(customer =>
    Object.values(customer).some(value => value.toLowerCase().includes(term))
  );

  renderRecords(filtered);
});

resetButton.addEventListener("click", () => {
  currentMode = "none";
  currentRecords = [];
  customerCount.textContent = "—";
  searchInput.value = "";
  customerResults.replaceChildren();
  statusMessage.textContent = "Choose an action above to display customer data.";
});
