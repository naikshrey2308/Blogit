// script for creating blog

let content = document.getElementById("blog-content");
let blockInserter = document.getElementById("block-insert-select");
let allImages = [];

content.addEventListener("keyup", (event) => {
    if(event.key == '/') {
        let selection = window.getSelection();
        let sx = 0, sy = 0;
        if (selection.rangeCount !== 0) {
            const range = selection.getRangeAt(0).cloneRange();
            range.collapse(true);
            const rect = range.getClientRects()[0];
            if (rect) {
              sx = rect.left;
              sy = rect.top;
            }
        }

        blockInserter.style.top = (window.scrollY + ~~sy - 250) + "px";
        blockInserter.style.left = ~~sx + "px";
        blockInserter.classList.remove("d-none");

    }
    else if(event.key === "Escape") {
        if(!blockInserter.classList.contains("d-none"))
            blockInserter.classList.add("d-none");
    }
});

function insertHeader() {
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");
    document.execCommand("insertHTML", false, "<h4>Heading...</h4>");
}

function insertImage(id) {
    document.getElementById("image-selector-modal-trigger").click();
    let time = Date.now();
    let iframe = document.getElementById("image-selector");
    iframe.src = `/blog/uploadImage?ticks=${time}`;
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");

    const iframeLoader = () => {
        if (allImages.indexOf(id) == -1)
            allImages.push(time);
        document.execCommand("insertHTML", false, `<img id="${time}" class="used-image my-3 w-100 br-10 mx-auto d-block" src="/assets/images/blogs/${time}.png" />`);
        iframe.removeEventListener("load", iframeLoader);
        document.getElementById("image-selector-modal-closer").click();
    }

    document.getElementById("image-selector-modal-closer").onclick = () => {
        iframe.removeEventListener("load", iframeLoader);
    }

    setTimeout(() => {
        iframe.addEventListener("load", iframeLoader);
    }, 1000);
}

function setBlogImage() {
    let image = document.getElementById("blog-image-top");
    image.click();
    
    image.addEventListener("change", () => {
        image = image.files[0];
        const url = URL.createObjectURL(image);
        document.getElementById("blog-image").src = url;
    });
}

function insertCode() {
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");
    document.execCommand("insertHTML", false, "<code> Your code here... </code>");
}

function insertBList() {
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");
    document.execCommand("insertUnorderedList", false);
}

function insertNList() {
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");
    document.execCommand("insertOrderedList", false);
}

function formatText(action) {
    if (!blockInserter.classList.contains("d-none"))
        blockInserter.classList.add("d-none");
    document.execCommand(action, false, "#ff914d88");
}

function finalize() {
    let usedImagesEle = [...document.getElementsByClassName("used-image")];
    let usedImages = [];
    usedImagesEle.forEach(ele => {
        usedImages.push(+ele.id);
    });
    let trashImages = allImages.filter(e => !usedImages.includes(e));

    document.getElementById("trash-images").value = trashImages.join(" ");
    document.getElementById("blog-heading-submit").value = document.getElementById("blog-heading").innerHTML;
    document.getElementById("blog-date-time").value = Date.now();
    document.getElementById("blog-content-submit").value = document.getElementById("blog-content").innerHTML;
    document.getElementById("category").value = document.getElementById("category-writer").value;
    console.log(document.getElementById("category").value);
    document.getElementById("form-submitter").click();

}