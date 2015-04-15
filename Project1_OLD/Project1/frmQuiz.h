#pragma once

namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for frmQuiz
	/// </summary>
	public ref class frmQuiz : public System::Windows::Forms::Form
	{
	public:
		frmQuiz(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~frmQuiz()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnPlay;
	private: System::Windows::Forms::Button^  btnHTP;
	private: System::Windows::Forms::Button^  btn;
	private: System::Windows::Forms::Button^  btnExit;
	protected:




	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(frmQuiz::typeid));
			this->btnPlay = (gcnew System::Windows::Forms::Button());
			this->btnHTP = (gcnew System::Windows::Forms::Button());
			this->btn = (gcnew System::Windows::Forms::Button());
			this->btnExit = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// btnPlay
			// 
			this->btnPlay->BackColor = System::Drawing::Color::White;
			this->btnPlay->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnPlay->Location = System::Drawing::Point(12, 236);
			this->btnPlay->Name = L"btnPlay";
			this->btnPlay->Size = System::Drawing::Size(180, 61);
			this->btnPlay->TabIndex = 0;
			this->btnPlay->Text = L"Play!";
			this->btnPlay->UseVisualStyleBackColor = false;
			this->btnPlay->Click += gcnew System::EventHandler(this, &frmQuiz::btnPlay_Click);
			this->btnPlay->MouseEnter += gcnew System::EventHandler(this, &frmQuiz::btnPlay_Click);
			// 
			// btnHTP
			// 
			this->btnHTP->BackColor = System::Drawing::Color::White;
			this->btnHTP->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnHTP->Location = System::Drawing::Point(198, 236);
			this->btnHTP->Name = L"btnHTP";
			this->btnHTP->Size = System::Drawing::Size(180, 61);
			this->btnHTP->TabIndex = 1;
			this->btnHTP->Text = L"How to Play";
			this->btnHTP->UseVisualStyleBackColor = false;
			// 
			// btn
			// 
			this->btn->BackColor = System::Drawing::Color::White;
			this->btn->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btn->Location = System::Drawing::Point(386, 236);
			this->btn->Name = L"btn";
			this->btn->Size = System::Drawing::Size(180, 61);
			this->btn->TabIndex = 2;
			this->btn->Text = L"HighScore";
			this->btn->UseVisualStyleBackColor = false;
			// 
			// btnExit
			// 
			this->btnExit->BackColor = System::Drawing::Color::White;
			this->btnExit->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnExit->Location = System::Drawing::Point(573, 236);
			this->btnExit->Name = L"btnExit";
			this->btnExit->Size = System::Drawing::Size(180, 61);
			this->btnExit->TabIndex = 3;
			this->btnExit->Text = L"Main Menu";
			this->btnExit->UseVisualStyleBackColor = false;
			// 
			// frmQuiz
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(765, 309);
			this->Controls->Add(this->btnExit);
			this->Controls->Add(this->btn);
			this->Controls->Add(this->btnHTP);
			this->Controls->Add(this->btnPlay);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"frmQuiz";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"frmQuiz";
			this->Load += gcnew System::EventHandler(this, &frmQuiz::frmQuiz_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void frmQuiz_Load(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void btnPlay_Click(System::Object^  sender, System::EventArgs^  e) {
	}
};
}
